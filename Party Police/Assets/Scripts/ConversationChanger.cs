using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ConversationChanger : MonoBehaviour
{
    [SerializeField]
    private Canvas _canvas = null;

    // UI Prefabs
    [SerializeField]
    private Text _textPrefab = null;
    [SerializeField]
    private Button _buttonPrefab = null;

    public Conversations[] allConversations;

    //public GameObject npc;
    //public TextAsset JSONStory;
    void Start()
    {
        for (int i = 0; i < allConversations.Length; i++)
        {
            allConversations[i].npc.canvas = _canvas;
            allConversations[i].npc.textPrefab = _textPrefab;
            allConversations[i].npc.buttonPrefab = _buttonPrefab;

            if (allConversations[i].intro != null)
            {
                allConversations[i].npc.inkJSONAsset = allConversations[i].intro;
            }
            else
            {
                allConversations[i].npc.inkJSONAsset = allConversations[i].conversations[0];
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    npc.GetComponent<BasicInkExample>().inkJSONAsset = JSONStory;
        //}
    }

    public void SetConversation(int conversationNumber)
    {
        for (int i = 0; i < allConversations.Length; i++)
        {
            if (allConversations[i].conversations[conversationNumber] != null)
            {
                allConversations[i].npc.inkJSONAsset = allConversations[i].conversations[conversationNumber];
            }
        }
    }
}
