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
    GameObject vero;
    GameObject tino;
    GameObject doni;

    void Start()
    {
        guru = Resources.Load<GameObject>("Guru");
        boy = Resources.Load<GameObject>("Murid Culun");
        girl = Resources.Load<GameObject>("Girl_FBX1");
        david = Resources.Load<GameObject>("David");
        devi = Resources.Load<GameObject>("Devi");
        alvin = Resources.Load<GameObject>("Alvin");
        vina = Resources.Load<GameObject>("Vina");
        vero = Resources.Load<GameObject>("Vero");
        tino = Resources.Load<GameObject>("Tino");
        doni = Resources.Load<GameObject>("Doni");
        listSpawn = FindObjectOfType<NPCSpawner>().spawns;
    }

    // Update is called once per frame
    void Update()
    {
        string[] dialog =  superScript.dialogProgress;
        int index =  superScript.indexDialog;
        Debug.Log(index);

        if (dialog[index] == "Day 1 part 1" & superScript.day == 1)
        {
          
            //dialog yang sekarang lagi play
            dialogStatus = "dialogday1_1";

            //di spawn di scene apa
            changeScene("kelas 1");

            addSpawn(guru, new Vector3(-2.43f, -0.358f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1.5f, 1.5f, 1.5f), "Guru");
            addNPC("Guru");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(-3.89f, -0.2017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Devi");
                addNPC("Devi");
            }
            
        }
        if (dialog[index] == "Day 1 part 2" & superScript.day == 1)
        {
            dialogStatus = "dialogday1_2";
            changeScene("kelas 1");
            removeNPC("Guru");
            //if (superScript.boy)
            //{
               // addSpawn(david, new Vector3(-3.89f, -0.1017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                //addNPC("David");
            //}
            //else
            //{
               // addSpawn(devi, new Vector3(-3.89f, -0.1017f, -2.24f), new Vector3(0f, 60f, 0f), new Vector3(1.07f, 1.07f, 1.07f), "Devi");
               // addNPC("Devi");
            //}
            if (superScript.boy)
            {
                addSpawn(alvin, new Vector3(-2.23f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                addSpawn(vina, new Vector3(-2.23f, 0.058f, -3.14f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }
        }

        else if (dialog[index] == "Day 1 part 3" & superScript.day == 1)
        {
            dialogStatus = "dialogday1_3";
            changeScene("kelas 1");
            removeNPC("David");
            removeNPC("Devi");
            

        }
        else if (dialog[index] == "Day 1 part 4" & superScript.day == 1)
        {
            removeNPC("Alvin");
            removeNPC("Vina");
            dialogStatus = "dialogday1_4";
            changeScene("GabungLorong");
            if (superScript.boy)
            {
                addSpawn(alvin, new Vector3(61.887f, 0.058f, -3.524f), new Vector3(0f, 270f, 0f), new Vector3(1f, 1f, 1f), "Alvin");
                addNPC("Alvin");
            }
            else
            {
                addSpawn(vina, new Vector3(61.887f, 0.058f, -3.524f), new Vector3(0f, 270f, 0f), new Vector3(1f, 1f, 1f), "Vina");
                addNPC("Vina");
            }
        }
        else if (dialog[index] == "Day 2 part 1 " & superScript.day == 2)
        {
            removeNPC("Alvin");
            removeNPC("Vina");
            dialogStatus = "dialogday2_1";
            changeScene("GabungLorong");
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(69.82f, 0.058f, -11.57f), new Vector3(0f, 180f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(69.82f, 0.058f, -11.57f), new Vector3(0f, 180f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Devi");
                addNPC("Devi");
            }

        }
        else if (dialog[index] == "Day 2 part 1 " & superScript.day == 2)
        {
            removeNPC("David");
            removeNPC("Devi");
            
            dialogStatus = "dialogday2_2";
            if (superScript.boy)
            {
                changeScene("Toilet Pria lt 1");
                addSpawn(david, new Vector3(46.106f, -0.08009219f, -0.072f), new Vector3(0f, 90f, 0f), new Vector3(1f, 1f, 1f), "David");
                addNPC("David");
                addSpawn(tino, new Vector3(46.646f, -0.08009219f, 0.748f), new Vector3(0f, 110f, 0f), new Vector3(1f, 1f, 1f), "Tino");
                addNPC("Tino");
                addSpawn(doni, new Vector3(46.66788f, -0.08009219f, -0.7924929f), new Vector3(0f, 60f, 0f), new Vector3(1f, 1f, 1f), "Doni");
                addNPC("Doni");
            }
            else
            {
                changeScene("Toilet Wanita lt 1");
                addSpawn(devi, new Vector3(37.075f, -0.40009148f, 1.222f), new Vector3(0f, 90f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Devi");
                addNPC("Devi");
                addSpawn(vero, new Vector3(37.284f, -0.40009148f, 1.918f), new Vector3(0f, 110f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Vero");
                addNPC("Vero");

            }
        }
        else if (dialog[index] == "Day 3 part 1 " & superScript.day == 3)
        {
            removeNPC("David");
            removeNPC("Devi");
            dialogStatus = "day3_1";
            if (superScript.boy)
            {
                addSpawn(david, new Vector3(62.38f, 4.119458f, -7.21f), new Vector3(0f, 240f, 0f), new Vector3(0.9f, 0.9f, 0.9f), "David");
                addNPC("David");
            }
            else
            {
                addSpawn(devi, new Vector3(62.38f, 4.119458f, -7.21f), new Vector3(0f, 240f, 0f), new Vector3(1.2f, 1.2f, 1.2f), "Devi");
                addNPC("Devi");
            }
        }
        else if (dialog[index] == "Day 3 part 2 " & superScript.day == 3)
        {
            dialogStatus = "day3_2";

        }
        else if (dialog[index] == "Day 3 part 3 " & superScript.day == 3)
        {
            dialogStatus = "day3_3";

        }
        else if (dialog[index] == "Day 4 " & superScript.day == 4)
        {
            dialogStatus = "dialogday4";

        }
        else if (dialog[index] == "Day 5 part 1 " & superScript.day == 5)
        {
            dialogStatus = "dialogday5_1";

        }
        else if (dialog[index] == "Day 5 part 1_1 " & superScript.day == 5)
        {
            dialogStatus = "dialogday5_1_1";

        }
        else if (dialog[index] == "Day 5 part 1_2 " & superScript.day == 5)
        {
            dialogStatus = "dialogday5_1_2";


        }
        else if (dialog[index] == "Day 5 part 1_3 " & superScript.day == 5)
        {
            dialogStatus = "dialogday5_1_3";

        }
        else if (dialog[index] == "Day 5 part 1_4" & superScript.day == 5)
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

    public void removeNPC(string name)
    {
        if (listNpc.Contains(name))
        {
            bool removed = FindObjectOfType<NPCSpawner>().removeNPC(name);
            if (removed)
            {
                listNpc.Remove(name);
            }
        }
        foreach (Spawn npcSpawn in listSpawn)
        {
            if (npcSpawn.name == name)
            {
                listSpawn.Remove(npcSpawn);
                break;
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
