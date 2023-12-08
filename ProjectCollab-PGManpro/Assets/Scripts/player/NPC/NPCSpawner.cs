using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class Spawn
{
    public GameObject prefabToSpawn;
    public Vector3 position;
    public Vector3 rotation;
    public Vector3 scale;
    public string name;

    public Spawn(GameObject prefabToSpawn, Vector3 position, Vector3 rotation, Vector3 scale, string name)
    {
        this.prefabToSpawn = prefabToSpawn;
        this.position = position;
        this.name = name;
        this.rotation = rotation;
        this.scale = scale;
    }
}

public class NPCSpawner : MonoBehaviour
{
    public GameObject SpawnPoint;

    public List<Spawn> spawns;
    public List<string> listSpawn;
    public List<GameObject> NPCSpawned;
    public string sceneName;
    public string currentSceneName;
    Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;

        if (currentSceneName == sceneName)
        {
            listSpawn = FindObjectOfType<NPCManager>().listNpc;
            foreach (Spawn spawn in spawns)
            {
                if (Search(spawn.name))
                {
                    GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform) as GameObject;
                    gameObject.transform.localScale = spawn.scale;
                    gameObject.transform.position = SpawnPoint.transform.position + spawn.position;
                    gameObject.transform.rotation = spawn.prefabToSpawn.transform.rotation;
                    gameObject.transform.rotation = Quaternion.Euler(spawn.rotation);
                    NPCSpawned.Add(gameObject);
                }
            }
        }
    }

    public bool SpawnNpc(string name)
    {
        if (currentSceneName == sceneName)
        {
            Spawn spawn = SearchNPC(name);
            if (spawn != null)
            {
                GameObject gameObject = Instantiate(spawn.prefabToSpawn, SpawnPoint.transform) as GameObject;
                gameObject.transform.localScale = spawn.scale;
                gameObject.transform.position = SpawnPoint.transform.position + spawn.position;
                gameObject.transform.rotation = spawn.prefabToSpawn.transform.rotation;
                gameObject.transform.rotation = Quaternion.Euler(spawn.rotation);
                NPCSpawned.Add(gameObject);
                return true;
            }
            else
            {
                Debug.Log("Spawn is Not Found");
            }
        }
        return false;
    }

    public bool Search(string name)
    {
        foreach (string nameSpawn in listSpawn)
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
        foreach (Spawn spawn in spawns)
        {
            if (spawn.name == name)
            {
                return spawn;
            }
        }
        return null;
    }

    public int SearchNPCIndex(string name)
    {
        int i = 0;
        foreach (Spawn spawn in spawns)
        {
            if (spawn.name == name)
            {
                return i;
            }
            i = i + 1;
        }
        return -1;
    }

    public bool removeNPC(string name)
    {
        if (currentSceneName == sceneName)
        {
            int index = SearchNPCIndex(name);

            if (index != -1)
            {
                GameObject toDestroy = NPCSpawned[index];
                Destroy(toDestroy);
                NPCSpawned.Remove(toDestroy);
                return true;
            }
            else
            {
                Debug.Log("Spawn is Not Found");
            }
        }
        return false;
    }

    public bool setSpawns(List<Spawn> listSpawn)
    {
        if (currentSceneName == sceneName)
        {
            this.spawns = listSpawn;
            return true;
        }
        return false;
    }
}
