using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue1 dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().SetNPCtrigerrer(gameObject.GetComponent<NPC>());
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
