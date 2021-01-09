using UnityEngine;

public class Player : MonoBehaviour
{
    Movement player = null;
    DialogueProgressTracker dialogueProgress = null;
    

    public float[] position;
    public bool haroldIntro1 = false;
    public bool visitedForest = false;
    public bool nextMorning = false;
    public bool startedIntros = false;
    public bool conversations1 = false;
    public bool conversations2 = false;
    public bool set2point5 = false;
    public bool setInvest3 = false;

    private void Start()
    {
        player = FindObjectOfType<Movement>();
        dialogueProgress = gameObject.GetComponent<DialogueProgressTracker>();
    }

    private void FixedUpdate()
    {
        if (player != null)
        {
            position = new float[3];
            position[0] = player.transform.position.x;
            position[1] = player.transform.position.y;
            position[2] = player.transform.position.z;
        }

        if (dialogueProgress != null)
        {
            haroldIntro1 = dialogueProgress.haroldIntro1;
            visitedForest = dialogueProgress.visitedForest;
            nextMorning = dialogueProgress.nextMorning;
            startedIntros = dialogueProgress.startedIntros;
            conversations1 = dialogueProgress.conversations1;
            set2point5 = dialogueProgress.set2point5;
            setInvest3 = dialogueProgress.setInvest3;
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        player.transform.position = position;

        haroldIntro1 = data.haroldIntro1;
        visitedForest = data.visitedForest;
        nextMorning = data.nextMorning;
        startedIntros = data.startedIntros;
        conversations1 = data.conversations1;
        conversations2 = data.conversations2;
        set2point5 = data.set2point5;
        setInvest3 = data.setInvest3;
    }


    //void Update()
    //{
    //    transform.position = new Vector2(Mathf.Clamp(transform.position.x, -22.79f, 22.79f), Mathf.Clamp(transform.position.y, -15.019f, 15.019f));

    //    //GUIUtility.ExitGUI();
    //}
}
