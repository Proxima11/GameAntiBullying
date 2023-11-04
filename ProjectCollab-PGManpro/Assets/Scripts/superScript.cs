using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superScript : MonoBehaviour
{

    static public bool boy = true;
    static public string username;
    static public int passiveAggresive = 50;
    static public int shyConfidence = 50;
    static public int nerdCool = 50;
    
    //Game Variable
    static public int score = 0;
    static public int stress = 0;
	static public int time = 0;
    static public int day = 1;

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
