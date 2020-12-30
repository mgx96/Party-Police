using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager1 : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Queue<string> sentences;

    private Movement thePlayer;

    private bool _isTalking;

    private BasicInkExample basicInk = null;

    private NPC1 npcTrigerrer = null;

    private Conversations currentConversation = null;

    [SerializeField]
    private ConversationChanger conversationChanger = null;

    private bool Found = false;


    void Start()
    {
        sentences = new Queue<string>();
        thePlayer = FindObjectOfType<Movement>();
    }

    private void FixedUpdate()
    {
        if (basicInk != null)
        {
            _isTalking = basicInk.isTalking;
            nameText.text = npcTrigerrer.gameObject.name;
            FindCurrentConversation();

            if (!_isTalking)
            {
                if (currentConversation.npc.inkJSONAsset == currentConversation.intro)
                {
                    currentConversation.npc.inkJSONAsset = currentConversation.conversations[0];
                }
                npcTrigerrer.SetIsTalking(false);
                nameText.text = null;
                npcTrigerrer = null;
                basicInk = null;
                currentConversation = null;
                Found = false;
            }
        }
    }

    private void Update()
    {
        if (_isTalking)
        {
            animator.SetBool("IsOpen", true);
            thePlayer.canMove = false;
        }

        if (!_isTalking)
        {
            animator.SetBool("IsOpen", false);
            thePlayer.canMove = true;
        }


    }

    public void SetNPCtrigerrer(NPC1 npc)
    {
        npcTrigerrer = npc;
        basicInk = npc.GetComponent<BasicInkExample>();
    }

    public void StartDialogue (Dialogue1 dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;
        
        sentences.Clear();

        thePlayer.canMove = false;

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("End of conversation.");
        thePlayer.canMove = true;
        npcTrigerrer.SetIsTalking(false);
    }

    void FindCurrentConversation()
    {
        if (!Found)
        {
            for (int i = 0; i < conversationChanger.allConversations.Length; i++)
            {
                if (basicInk == conversationChanger.allConversations[i].npc)
                {
                    currentConversation = conversationChanger.allConversations[i];
                    Found = true;
                }
            }
        }
    }
}
