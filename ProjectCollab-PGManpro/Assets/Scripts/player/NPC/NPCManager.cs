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
    GameObject guru;
    GameObject david;
    GameObject devi;
    GameObject alvin;
    GameObject vina;
    GameObject tino;

    void Start()
    {
        guru = Resources.Load<GameObject>("Guru");
        boy = Resources.Load<GameObject>("Murid Culun");
        girl = Resources.Load<GameObject>("Girl_FBX1");
        david = Resources.Load<GameObject>("David");
        devi = Resources.Load<GameObject>("Devi");
        alvin = Resources.Load<GameObject>("Alvin");
        vina = Resources.Load<GameObject>("Vina");
        tino = Resources.Load<GameObject>("Tino");
        listSpawn = FindObjectOfType<NPCSpawner>().spawns;
    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;

        if (dialog[index] == "Day 1 part 1")
        {
          
            //dialog yang sekarang lagi play
            dialogStatus = "dialogday1_1";

            //di spawn di scene apa
            changeScene("kelas 1");

            addSpawn(guru, new Vector3(-2.43f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(-3.89f, -0.1017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(-3.89f, -0.1017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(1f, 1f, 1f), "Devi");
                addNPC("Devi");
            }
        }
        else if (dialog[index] == "Day 1 part 2")
        {
            dialogStatus = "dialogday1_2";
            addNPC("Alvin");
            addNPC("David");
            removeNPC("David");
            changeScene("kelas");
        }

        else if (dialog[index] == "Day 1 part 3")
        {
            dialogStatus = "dialogday1_3";
        }
        else if (dialog[index] == "Day 1 part 4")
        {
            dialogStatus = "dialogday1_4";
        }
        else if (dialog[index] == "Day 2 part 1")
        {
            dialogStatus = "dialogday2_1";

        }
        else if (dialog[index] == "Day 2 part 2")
        {
            dialogStatus = "dialogday2_2";


        }
        else if (dialog[index] == "Day 3 part 1")
        {
            dialogStatus = "day3_1";

        }
        else if (dialog[index] == "Day 3 part 2")
        {
            dialogStatus = "day3_2";

        }
        else if (dialog[index] == "Day 3 part 3")
        {
            dialogStatus = "day3_3";

        }
        else if (dialog[index] == "Day 4")
        {
            dialogStatus = "dialogday4";

        }
        else if (dialog[index] == "Day 5 part 1")
        {
            dialogStatus = "dialogday5_1";

        }
        else if (dialog[index] == "Day 5 part 1_1")
        {
            dialogStatus = "dialogday5_1_1";

        }
        else if (dialog[index] == "Day 5 part 1_2")
        {
            dialogStatus = "dialogday5_1_2";


        }
        else if (dialog[index] == "Day 5 part 1_3")
        {
            dialogStatus = "dialogday5_1_3";

        }
        else if (dialog[index] == "Day 5 part 1_4")
        {
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

    public void addSpawn(GameObject prefab, Vector3 position, Vector3 rotation, Vector3 scale, string name){
        bool isExist = false;
        foreach(Spawn npcSpawn in listSpawn){
            if(npcSpawn.name == name){
                isExist = true;
                break;
            }
        }

        if(!isExist){
            Spawn spawn = new Spawn(prefab, position,rotation, scale, name);
            listSpawn.Add(spawn);
        }
    }
}
