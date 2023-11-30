using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public string dialogStatus;
    public List<string> listNpc = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        string[] dialog = superScript.dialogProgress;
        int index = superScript.indexDialog;

        if (dialog[index] == "Day 1 Begining")
        {
            dialogStatus = "Day 1";
            listNpc.Add("Alvin");
            

        }
        else if (dialog[index] == "Day 1 Mid")
        {
            dialogStatus = "New Ink";
        }
        Debug.Log(dialogStatus);
    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;
        
        if (dialog[index] == "Day 1 Begining"){
            dialogStatus = "Day 1";
            listNpc.Add("Alvin");
            listNpc.Add("David");

        }
        else if (dialog[index] == "Day 1 Mid"){
            dialogStatus = "New Ink";
        }
        Debug.Log(dialogStatus);    
    }
}
