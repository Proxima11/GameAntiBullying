using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public string dialogStatus;
    public List<string> listNpc = new List<string>(); 
    public List<Spawn> listSpawn;
    GameObject boy;
    GameObject girl;

    void Start(){
        boy = Resources.Load<GameObject>("Murid Culun");
        girl = Resources.Load<GameObject>("Girl_FBX1");
        listSpawn = FindObjectOfType<NPCSpawner>().spawns;
    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;
        
        if (dialog[index] == "Day 1 part 1"){
            //dialog yang sekarang lagi play
            dialogStatus = "dialogday1_1";

            //di spawn di scene apa
            changeScene("Lorong lt 2");

            //add posisi spawn
            addSpawn(boy, new Vector3(-3f,-0.432f,6f), "Alvin");       
            addSpawn(girl, new Vector3(-0.84f,-0.432f,22f), "David");

            //spawn NPC sesuai nama Spawn di atas
            addNPC("Alvin");
            addNPC("David");

        }
        else if (dialog[index] == "Day 1 part 2"){
            dialogStatus = "dialogday1_2";
            addNPC("Alvin");
            addNPC("David");
            removeNPC("David");
            changeScene("kelas");
        }  
        else if (dialog[index] == "Day 2 part 1"){
            dialogStatus = "dialogday2_1";
            
        }
        else if (dialog[index] == "Day 2 part 2"){
            dialogStatus = "dialogday2_2";

            
        }
        else if (dialog[index] == "Day 3 part 1"){
            dialogStatus = "day3_1";

        }
        else if (dialog[index] == "Day 3 part 2"){
            dialogStatus = "day3_2";

        }
        else if (dialog[index] == "Day 3 part 3"){
            dialogStatus = "day3_3";

        }
        else if (dialog[index] == "Day 4"){
            dialogStatus = "dialogday4";
            
        }
        else if (dialog[index] == "Day 5 part 1"){
            dialogStatus = "dialogday5_1";
            
        }
        else if (dialog[index] == "Day 5 part 1_1"){
            dialogStatus = "dialogday5_1_1";
            
        }
        else if (dialog[index] == "Day 5 part 1_2"){
            dialogStatus = "dialogday5_1_2";
            

        }
        else if (dialog[index] == "Day 5 part 1_3"){
            dialogStatus = "dialogday5_1_3";
            
        }
        else if (dialog[index] == "Day 5 part 1_4"){
            dialogStatus = "dialogday5_1_4";

            
        }
    }

    public void addNPC(string name){
        if (!listNpc.Contains(name)){
            bool added = FindObjectOfType<NPCSpawner>().SpawnNpc(name);
            if (added){
                listNpc.Add(name);
            }
        }
    }

    public void removeNPC(string name){
        if (listNpc.Contains(name)){
            bool removed = FindObjectOfType<NPCSpawner>().removeNPC(name);
            if (removed){
                listNpc.Remove(name);
            }
        }
    }

    public void changeScene(string name){
        FindObjectOfType<NPCSpawner>().sceneName = name;
    }   

    public void addSpawn(GameObject prefab, Vector3 position, string name){
        bool isExist = false;
        foreach(Spawn npcSpawn in listSpawn){
            if(npcSpawn.name == name){
                isExist = true;
                break;
            }
        }

        if(!isExist){
            Spawn spawn = new Spawn(prefab, position, name);
            listSpawn.Add(spawn);
        }
    }
}
