using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WayToForest : MonoBehaviour
{
    private bool canClick = false;
    bool canTalk = false;

    [SerializeField]
    DialogueProgressTracker dialogueProgress;


    void Update()
    {
        if (canClick && Input.GetMouseButtonDown(0) && canTalk)
        {
            if (dialogueProgress.invest1Progress[dialogueProgress.invest1Progress.Length - 1] != null) 
            {
                dialogueProgress.conversations1 = true;
                SceneManager.LoadScene("Stefan's Forest Scene");
            }
            else
            {
                this.GetComponent<BasicInkExample>().StartStory();
            }
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
