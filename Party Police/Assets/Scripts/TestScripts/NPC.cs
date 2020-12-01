using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
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

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canTalk && isTalking == false)
        {
            gameObject.GetComponent<DialogueTrigger>().TriggerDialogue();
            isTalking = true;
        }
    }

}
