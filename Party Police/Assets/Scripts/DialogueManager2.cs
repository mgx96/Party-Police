using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager2 : MonoBehaviour
{
    private Queue<string> sentences;
    public Text nameText;
    public Text dialogueText;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue1 dialogue)
    {
        //Debug.Log("Starting conversation with" + dialogue.name);

        dialogueText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue1();
            return;
        }

        string sentence = sentences.Dequeue();

        dialogueText.text = sentence;
    }

    void EndDialogue1 ()
    {
        Debug.Log("End of conversation");
    }
}
