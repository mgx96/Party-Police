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

    [SerializeField]
    private DialogueProgressTracker dialogueProgress = null;

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
            FindCurrentConversation();
            //nameText.text = npcTrigerrer.gameObject.name;
            nameText.text = currentConversation.npcName;

            if (!_isTalking)
            {
                //To check if you've talked to everyone in invest 1
                if (currentConversation.npc.inkJSONAsset == currentConversation.conversations[0])
                {
                    for (int i = 0; i < dialogueProgress.invest1Progress.Length; i++)
                    {
                        if (currentConversation.npcName == dialogueProgress.invest1Progress[i])
                        {
                            break;
                        }
                        else if (dialogueProgress.invest1Progress[i] == null)
                        {
                            dialogueProgress.invest1Progress[i] = currentConversation.npcName;
                            break;
                        }
                    }
                }
                //


                //So we know when Harold intro has been played
                if (currentConversation.npcName == "Harald" && currentConversation.npc.inkJSONAsset == currentConversation.intro)
                {
                    dialogueProgress.haroldIntro1 = true;
                }
                //
                //To switch from intro to first conversation
                else if (currentConversation.npc.inkJSONAsset == currentConversation.intro)
                {
                    currentConversation.npc.inkJSONAsset = currentConversation.conversations[0];
                }
                //

                //To know when enough people for 2.5 have been talked to
                if (dialogueProgress.conversations2 && !dialogueProgress.set2point5)
                {
                    for (int i = 0; i < dialogueProgress.talkedTo.Length; i++)
                    {
                        if (currentConversation.npcName == dialogueProgress.talkedTo[i])
                        {
                            break;
                        }
                        else if (dialogueProgress.talkedTo[i] == "")
                        {
                            dialogueProgress.talkedTo[i] = currentConversation.npcName;
                            break;
                        }
                    }
                }
                //
                //To know if you talked to Harald and Gro in 2.5
                if (currentConversation.npcName == "Harald")
                {
                    if (currentConversation.npc.inkJSONAsset == currentConversation.conversations[2])
                    {
                        dialogueProgress.harald2point5 = true;
                    }
                }

                else if (currentConversation.npcName == "Gro")
                {
                    if (currentConversation.npc.inkJSONAsset == currentConversation.conversations[2])
                    {
                        dialogueProgress.gro2point5 = true;
                    }
                }
                
                //
                //To move Harald past intro 2
                if (currentConversation.npcName == "Harald")
                {
                    if (currentConversation.npc.inkJSONAsset == currentConversation.conversations[3])
                    {
                        currentConversation.npc.inkJSONAsset = currentConversation.conversations[4];
                    }
                }
                //
                //To check if Birger 3.5 is talked to
                if (currentConversation.npcName == "Birger")
                {
                    if (currentConversation.npc.inkJSONAsset == currentConversation.conversations[3])
                    {
                        dialogueProgress.birger3point5 = true;
                    }
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
