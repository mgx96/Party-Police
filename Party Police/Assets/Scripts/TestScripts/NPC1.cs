using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{

    private bool canTalk = false;
    private bool isTalking = false;



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

    public void SetIsTalking(bool state)
    {
        isTalking = state;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canTalk && isTalking == false)
        {
            gameObject.GetComponent<BasicInkExample>().StartStory();
            //gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            isTalking = true;
        }
    }

}
