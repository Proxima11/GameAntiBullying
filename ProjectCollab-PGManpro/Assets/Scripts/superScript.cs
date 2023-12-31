using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class superScript : MonoBehaviour
{
    static public bool boy = false;
    static public string username = "player";
    static public float passiveAggresive = 0.5f;
    static public float shyConfidence = 0.5f;
    static public float nerdCool = 0.5f;

    //Game Variable
    static public bool isNeedStudying = false;
    static public int score = 0;
    static public int stress = 0;
	static public float time = 0;
    static public int day = 1;
    public static int[] done_quiz = {0,0,0,0,0};
    public static List<Task_def> Tasks = new List<Task_def>();
    public static List<int> idx_coolTasks = new List<int>();
    public static List<int> idx_acaTasks = new List<int>();
    static public string[] dialogProgress = new string[] {
        "Day 1 part 1",
        "Day 1 part 2",
        "Day 1 part 3",
        "Day 1 part 4",
        "Day 2 part 1 ",
        "Day 2 part 2 ",
        "Day 3 part 1 ",
        "Day 3 part 2 ",
        "Day 3 part 3 ",
        "Day 4 ",
        "Day 5 part 1 ",
        "Day 5 part 1_1 ",
        "Day 5 part 1_2 ",
        "Day 5 part 1_3 ",
        "Day 5 part 1_4 ",
        "End"
        };
    
    static public List<string> choices = new List<string>();
    static public int indexDialog = 0;
    static public List<Item> itemOnwed = new List<Item>();
    static public List<int> itemIndex = new List<int>();
    static public List<string> removedNPC = new List<string>();
    static public List<int> indexRandomEvent = new List<int>();

    static public void setVariable (int inputScore, int inputStress, float inputTime, int inputDay){
        score = inputScore;
        stress = inputStress;
        time = inputTime;
        day = inputDay;
    }

    static public void resetVariable(){
        score = 0;
        stress = 0;
        time = 0;
        day = 1;
        indexDialog = 0;
        isNeedStudying = false;
        itemOnwed = new List<Item>();
        itemIndex = new List<int>();
        choices = new List<string>();
        idx_acaTasks = new List<int>();
        idx_coolTasks = new List<int>();
        removedNPC = new List<string>();
        indexRandomEvent = new List<int>();
        itemIndex.Add(0);
        itemIndex.Add(1);
        itemIndex.Add(1);
        itemIndex.Add(2);   
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void updateTime(float t, int d){
        time = t;
        day = d;
    }
}
