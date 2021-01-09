using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public Canvas myCanvas;
    public Dialogue1 dialogue;

    private void Awake()
    {
        myCanvas.enabled = false;
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Trigger Enter");

        if (collider.name == "Player")
        {
            myCanvas.enabled = true;

            TriggerDialogue();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Enter");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Collision Stay");

    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("Trigger Stay");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Collision Exit");
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Trigger Exit");

        if (collider.name == "Player")
        {
            myCanvas.enabled = false;
        }

    }
}
