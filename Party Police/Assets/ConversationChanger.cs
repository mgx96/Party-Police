using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationChanger : MonoBehaviour
{

    public GameObject npc;
    public TextAsset JSONStory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            npc.GetComponent<BasicInkExample>().inkJSONAsset = JSONStory;
        }
    }
}
