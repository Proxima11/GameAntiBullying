using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_cool : Task_def
{
    // Start is called before the first frame update
    private bool done_this=false;
    private string name_this="ini tugas keren";
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void task(){
        Debug.Log("tes");
    }

    public override string id{
        get{
            return "pt_cool";
        }
    }

    public override string taskName{
        get {
            return name_this;
        }
        set {
            name_this=value;
        }
    }
    public override bool done{
        get {
            return done_this;
        }
        set {
            done_this=value;
        }
    }
}
