using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PT_aca : Task_def
{
    // Start is called before the first frame update
    private bool done_this=true;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override string taskName{
        get {
            return "ini tugas akademik";
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
