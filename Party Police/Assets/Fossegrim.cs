using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fossegrim : MonoBehaviour
{
    private bool canTalk = false;
    private bool isTalking = false;
    private bool canClick = false;
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    private Movement thePlayer;

    public BasicInkExample basicInk = null;

    DialogueProgressTracker dialogueProgress = null;



    void Start()
    {
        thePlayer = FindObjectOfType<Movement>();
        dialogueProgress = FindObjectOfType<DialogueProgressTracker>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canClick && canTalk && isTalking == false && dialogueProgress.setInvest3)
        {
            gameObject.GetComponent<BasicInkExample>().StartStory();
            //gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            isTalking = true;
        }


        if (basicInk != null)
        {
            isTalking = basicInk.isTalking;
            nameText.text = "Fossegrim";
            if (!isTalking)
            {
                basicInk = null;
                gameObject.GetComponent<NPC1>().SetIsTalking(false);
            }
        }

        if (isTalking)
        {
            animator.SetBool("IsOpen", true);
            thePlayer.canMove = false;
        }

        if (!isTalking)
        {
            animator.SetBool("IsOpen", false);
            thePlayer.canMove = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player in range");
        }

        canTalk = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player left range");
        }

        canTalk = false;
        isTalking = false;
    }

    private void OnMouseOver()
    {
        canClick = true;
    }

    private void OnMouseExit()
    {
        canClick = false;
    }
}
