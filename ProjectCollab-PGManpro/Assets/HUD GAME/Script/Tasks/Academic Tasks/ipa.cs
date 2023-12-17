using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ipa : Task_def
{
    // Start is called before the first frame update
    private bool done_this=false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void task(){
        if (!done_this){
            
                done_this = true;
                getSnacks();
            
        }
    }
public override string id{
        get{
            return "a_ipa";
        }
    }
    private string name_this1="Kerjakan 1 set soal IPA di kelas 2!";
    public override string taskName{
        get {
            return name_this1;
        }
        set {
            name_this1=value;
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
