using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData 
{
    public bool boy;
    public string username;
    public float passiveAggresive;
    public float shyConfidence;
    public float nerdCool;

    public float[] position;
    public int stress;
    public int score;
    public float time;
    public int day;

    public int indexDialog;
    public List<Task_def> tasks;
    public List<int> items;

    
    public PlayerData (GameVariable gameVariable, Vector3 playerPosition) 
    {
        this.position = new float[] { playerPosition.x, playerPosition.y, playerPosition.z };
        this.stress = gameVariable.stress;
        this.score = gameVariable.score;
        this.time = gameVariable.timeNow;
        this.day = gameVariable.day;
    }
}