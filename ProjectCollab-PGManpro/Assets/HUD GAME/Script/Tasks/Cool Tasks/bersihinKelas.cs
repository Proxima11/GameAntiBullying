using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bersihinKelas : Task_def
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
            countKenalan--;
            if (countKenalan == 0){
                done_this = true;
            }
        }
    }
public override string id{
        get{
            return "c_bersihinKelas";
        }
    }
    private string name_this1="Bersihkan ";
    private string name_this2 =" sampah di kelas-kelas";
    public override string taskName{
        get {
            return name_this1 + countKenalan + name_this2;
        }
        set {
            name_this1=value;
        }
    }

    private static int countKenalan = 8;
    public override bool done{
        get {
            return done_this;
        }
        set {
            done_this=value;
        }
    }
}
