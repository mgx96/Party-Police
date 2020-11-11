using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckClickable : MonoBehaviour
{
    ClickItem parentScript;
    // Start is called before the first frame update
    void Start()
    {
        parentScript = gameObject.GetComponentInParent<ClickItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hi Ted");
        if (collision.CompareTag("Player"))
        {
            parentScript.SetCanClick(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Bye Ted");
        if (collision.CompareTag("Player"))
        {
            parentScript.SetCanClick(false);
        }
    }
}
