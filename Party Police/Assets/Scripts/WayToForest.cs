using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class WayToForest : MonoBehaviour
{
    private bool canClick = false;




    void Update()
    {
        if (canClick && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Stefan's Forest Scene");
        }
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
