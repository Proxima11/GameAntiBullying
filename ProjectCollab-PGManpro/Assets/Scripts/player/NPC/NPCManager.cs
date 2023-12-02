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
            dialogStatus = "New Ink";
            addNPC("Alvin");
            addNPC("David");
        }
        else if (dialog[index] == "Day 1 Mid"){
            dialogStatus = "Day 1";
            addNPC("Alvin");
            addNPC("David");
            removeNPC("David");
        }
        Debug.Log(dialogStatus);    
    }

    public void addNPC(string name){
        if (!listNpc.Contains(name)){
            listNpc.Add(name);
            FindObjectOfType<NPCSpawner>().SpawnNpc(name);
        }
    }

    public void removeNPC(string name){
        if (listNpc.Contains(name)){
            listNpc.Remove(name);
            FindObjectOfType<NPCSpawner>().removeNPC(name);
        }
    }
}
