using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superScript : MonoBehaviour
{
    static public bool boy = false;
    static public string username;
    static public float passiveAggresive = 0.5f;
    static public float shyConfidence = 0.5f;
    static public float nerdCool = 0.5f;
    
    //Game Variable
    static public int score = 0;
    static public int stress = 0;
	static public int time = 0;
    static public int day = 1;
    static public string[] dialogProgress = new string[] {
        "Day 1 Begining",
        "Day 1 Mid",
        "Day 1 End",
        "Day 2 Begining"
        };
    static public int indexDialog = 0;

    static public void setVariable (int inputScore, int inputStress, int inputTime, int inputDay){
        score = inputScore;
        stress = inputStress;
        time = inputTime;
        day = inputDay;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
