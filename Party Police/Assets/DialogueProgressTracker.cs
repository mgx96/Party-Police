using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueProgressTracker : MonoBehaviour
{
    [SerializeField]
    private DialogueManager1 dialogueManager = null;

    [SerializeField]
    private ConversationChanger conversationChanger = null;

    public string[] switchOne;
    public string[] switchTwo;
    public string[] switchThree;

    [SerializeField]
    int conversationsForFirstSwitch = 10;
    [SerializeField]
    int conversationsForSecondSwitch = 10;
    [SerializeField]
    int conversationsForThirdSwitch = 10;


    //Bools for first switch
    //public bool ulf1 = false;
    //public bool toke1 = false;
    //public bool yrsa1 = false;
    //public bool sten1 = false;
    //public bool birger1 = false;
    //public bool gro1 = false;
    //public bool harold1 = false;
    //public bool sigrid1 = false;
    bool switchedOnce = false;

    //Bools for second switch
    //public bool ulf2 = false;
    //public bool toke2 = false;
    //public bool yrsa2 = false;
    //public bool sten2 = false;
    //public bool birger2 = false;
    //public bool gro2 = false;
    //public bool harold2 = false;
    //public bool sigrid2 = false;
    bool switchedTwice = false;

    //Bools for third switch
    //public bool ulf3 = false;
    //public bool toke3 = false;
    //public bool yrsa3 = false;
    //public bool sten3 = false;
    //public bool birger3 = false;
    //public bool gro3 = false;
    //public bool harold3 = false;
    //public bool sigrid3 = false;
    bool switchedThrice = false;

    bool[] firstSwitch;
    bool[] secondSwitch;
    bool[] thirdSwitch;

    // Start is called before the first frame update
    void Start()
    {
        //firstSwitch = new bool[] { ulf1, toke1, yrsa1, sten1, birger1, gro1, harold1, sigrid1 };
        //secondSwitch = new bool[] { ulf2, toke2, yrsa2, sten2, birger2, gro2, harold2, sigrid2 };
        //thirdSwitch = new bool[] { ulf3, toke3, yrsa3, sten3, birger3, gro3, harold3, sigrid3 };
    }

    // Update is called once per frame
    void Update()
    {
        if (!switchedOnce)
        {
            int falseCounter = firstSwitch.Length;
            for (int i = 0; i < firstSwitch.Length; i++)
            {
                if (firstSwitch[i])
                {
                    falseCounter--;
                }
            }

            if (falseCounter == 0)
            {
                conversationChanger.SetConversation(1);
            }
        }
        else if (!switchedTwice)
        {
            int falseCounter = secondSwitch.Length;
            for (int i = 0; i < secondSwitch.Length; i++)
            {
                if (secondSwitch[i])
                {
                    falseCounter--;
                }
            }

            if (falseCounter == 0)
            {
                conversationChanger.SetConversation(2);
            }
        }
        else if (!switchedThrice)
        {
            int falseCounter = thirdSwitch.Length;
            for (int i = 0; i < thirdSwitch.Length; i++)
            {
                if (thirdSwitch[i])
                {
                    falseCounter--;
                }
            }

            if (falseCounter == 0)
            {
                conversationChanger.SetConversation(3);
            }
        }
    }
}
