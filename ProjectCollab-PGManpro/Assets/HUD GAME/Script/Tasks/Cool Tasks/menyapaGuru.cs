using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menyapaGuru : Task_def
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
            countSapa--;
            if (countSapa == 0){
                done_this = true;
                getSnacks();
            }
        }
    }
public override string id{
        get{
            return "c_menyapaGuru";
        }
    }
    private string name_this1="Menyapa ";
    private string name_this2 =" guru";
    public override string taskName{
        get {
            return name_this1 + countSapa + name_this2;
        }
        set {
            name_this1=value;
        }
    }

    private static int countSapa = 2;
    public override bool done{
        get {
            return done_this;
        }
        set {
            done_this=value;
        }
    }
}
