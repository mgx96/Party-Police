using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;
    public bool haroldIntro1 = false;
    public bool visitedForest = false;
    public bool nextMorning = false;
    public bool startedIntros = false;
    public bool conversations1 = false;
    public bool conversations2 = false;
    public bool set2point5 = false;
    public bool setInvest3 = false;



    public PlayerData(Player player)
    {
        //level = player.level;
        //health = player.health;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;

        haroldIntro1 = player.haroldIntro1;
        visitedForest = player.visitedForest;
        nextMorning = player.nextMorning;
        startedIntros = player.startedIntros;
        conversations1 = player.conversations1;
        set2point5 = player.set2point5;
        setInvest3 = player.setInvest3;
    }
}
