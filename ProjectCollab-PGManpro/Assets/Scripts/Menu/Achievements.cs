using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Achievements
{
    // Start is called before the first frame update
   public int score = 0;
   public int stress = 0;
   public int tasks = 0;
   public string notes = "";
   public string uname = "";
   public bool isboy = false;
   public bool iswin = false;
   public string date = "";
    void Start()
    {
    }

    public Achievements(string uname, string date, bool isBoy, bool isWin, int score, int tasks, int stress, string notes){
        this.uname = uname;
        this.date = date;
        this.isboy = isBoy;
        this.iswin = isWin;
        this.score = score;
        this.tasks = tasks;
        this.stress = stress;
        this.notes = notes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
