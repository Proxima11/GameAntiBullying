using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spawn {
    public GameObject prefabToSpawn;
    public Vector3 position;
    public string name;

}

public class NPCSpawner : MonoBehaviour
{
    public GameObject SpawnPoint;

    public Spawn[] spawns;
    public List<string> listSpawn;
    public List<GameObject> NPCSpawned;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        listSpawn = FindObjectOfType<NPCManager>().listNpc;
        foreach (Spawn spawn in spawns){
            if (Search(spawn.name)){
                GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform) as GameObject;
                gameObject.transform.position = SpawnPoint.transform.position + spawn.position;
                gameObject.transform.rotation = spawn.prefabToSpawn.transform.rotation;
                NPCSpawned.Add(gameObject);
            }
        }
    }

    public void SpawnNpc(string name)
    {
        Spawn spawn = SearchNPC(name);
        if (spawn != null){
            GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform) as GameObject;
            gameObject.transform.position = SpawnPoint.transform.position + spawn.position;
            gameObject.transform.rotation = spawn.prefabToSpawn.transform.rotation;
            NPCSpawned.Add(gameObject);
        }else{
            Debug.Log("Spawn is Not Found");
        }
    }

    public bool Search(string name)
    {
        foreach(string nameSpawn in listSpawn)
        {
            if (nameSpawn == name)
            {
                return true;
            }
        }
        return false;
    }

    public Spawn SearchNPC(string name)
    {
        foreach(Spawn spawn in spawns)
        {
            if (spawn.name == name)
            {
                return spawn;
            }
        }
        return null;
    }

    public int SearchNPCIndex(string name){
        int i = 0;
        foreach(Spawn spawn in spawns)
        {
            if (spawn.name == name)
            {
                return i;
            }
            i=i+1;
        }
        return -1;
    }

    public void removeNPC(string name){
        int index = SearchNPCIndex(name);

        if (index != -1){
            GameObject toDestroy = NPCSpawned[index];
            Destroy(toDestroy);
            NPCSpawned.Remove(toDestroy);
        }else{
            Debug.Log("Spawn is Not Found");
        }
        
    }
}
