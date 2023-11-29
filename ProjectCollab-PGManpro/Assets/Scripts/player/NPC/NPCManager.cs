using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public string dialogStatus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;
        
        if (dialog[index] == "Day 1 Begining"){
            dialogStatus = "Day 1";
        }else if (dialog[index] == "Day 1 Mid"){
            dialogStatus = "New Ink";
        }
        Debug.Log(dialogStatus);    
    }
}
