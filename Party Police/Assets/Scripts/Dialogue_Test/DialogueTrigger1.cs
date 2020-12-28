using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager2>().SetNPCtrigerrer(gameObject.GetComponent<NPC>());
        FindObjectOfType<DialogueManager2>().StartDialogue(dialogue);
    }
}
