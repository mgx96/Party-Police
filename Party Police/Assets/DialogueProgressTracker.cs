using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueProgressTracker : MonoBehaviour
{
    //[SerializeField]
    //private DialogueManager1 dialogueManager = null;

    [SerializeField]
    private ConversationChanger conversationChanger = null;


    public bool haroldIntro1 = false;
    public bool visitedForest = false;
    public bool nextMorning = false;

    public string[] talkedTo;

    public bool startedIntros = false;
    public bool conversations1 = false;
    public bool set2point5 = false;
    public bool setInvest3 = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        talkedTo = new string[3] { null, null, null };
        //firstSwitch = new bool[] { ulf1, toke1, yrsa1, sten1, birger1, gro1, harold1, sigrid1 };
        //secondSwitch = new bool[] { ulf2, toke2, yrsa2, sten2, birger2, gro2, harold2, sigrid2 };
        //thirdSwitch = new bool[] { ulf3, toke3, yrsa3, sten3, birger3, gro3, harold3, sigrid3 };
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().buildIndex == 1)
        if (SceneManager.GetActiveScene().name == "AXLROSE")
        {
            if (haroldIntro1 && !startedIntros)
            {
                conversationChanger.StartIntros();
                startedIntros = true;
            }

            else if (visitedForest && !conversations1)
            {
                conversationChanger.SetConversation(1);
                conversations1 = true;
                Debug.Log("smile");
            }

            else if (conversations1 && !set2point5)
            {
                for (int i = 0; i < talkedTo.Length; i++)
                {
                    if (talkedTo[i] == "")
                    {
                        break;
                    }
                    else
                    {
                        if (i == talkedTo.Length - 1)
                        {
                            conversationChanger.SetConversation2point5();
                            set2point5 = true;
                        }
                    }
                }
            }

            else if (nextMorning && !setInvest3)
            {
                conversationChanger.SetBirgerHarold3();
                setInvest3 = true;
            }
        }













        //if (!switchedOnce)
        //{
        //    int falseCounter = firstSwitch.Length;
        //    for (int i = 0; i < firstSwitch.Length; i++)
        //    {
        //        if (firstSwitch[i])
        //        {
        //            falseCounter--;
        //        }
        //    }

        //    if (falseCounter == 0)
        //    {
        //        conversationChanger.SetConversation(1);
        //    }
        //}
        //else if (!switchedTwice)
        //{
        //    int falseCounter = secondSwitch.Length;
        //    for (int i = 0; i < secondSwitch.Length; i++)
        //    {
        //        if (secondSwitch[i])
        //        {
        //            falseCounter--;
        //        }
        //    }

        //    if (falseCounter == 0)
        //    {
        //        conversationChanger.SetConversation(2);
        //    }
        //}
        //else if (!switchedThrice)
        //{
        //    int falseCounter = thirdSwitch.Length;
        //    for (int i = 0; i < thirdSwitch.Length; i++)
        //    {
        //        if (thirdSwitch[i])
        //        {
        //            falseCounter--;
        //        }
        //    }

        //    if (falseCounter == 0)
        //    {
        //        conversationChanger.SetConversation(3);
        //    }
        //}
    }
}
