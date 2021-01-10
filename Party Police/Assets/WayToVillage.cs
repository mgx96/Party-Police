using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WayToVillage : MonoBehaviour
{
    private bool canClick = false;
    private bool canTalk = false;

    [SerializeField]
    DialogueProgressTracker dialogueProgress = null;

    private void Start()
    {
        dialogueProgress = FindObjectOfType<DialogueProgressTracker>();
    }

    void Update()
    {
        if (canClick && Input.GetMouseButtonDown(0) && canTalk)
        {
            dialogueProgress.visitedForest = true;
            SceneManager.LoadScene(1);
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
