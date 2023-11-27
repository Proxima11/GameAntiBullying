using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spawn {
    public GameObject prefabToSpawn;
    public Vector3 position;

}

public class NPCSpawner : MonoBehaviour
{
    public GameObject SpawnPoint;

    public Spawn[] spawns;


    
    // Start is called before the first frame update
    void Start()
    {
        foreach(Spawn spawn in spawns){
            GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform.position +spawn.position, SpawnPoint.transform.rotation) as GameObject; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
