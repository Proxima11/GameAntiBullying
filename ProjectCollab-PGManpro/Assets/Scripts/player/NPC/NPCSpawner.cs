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

    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        listSpawn = FindObjectOfType<NPCManager>().listNpc;
        int i = 0;
        foreach (Spawn spawn in spawns){
            if (Search(spawn.name)){
                
                GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform) as GameObject;
                gameObject.transform.position = SpawnPoint.transform.position + spawn.position;
                gameObject.transform.rotation = spawn.prefabToSpawn.transform.rotation;
            }
            i = i+1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
