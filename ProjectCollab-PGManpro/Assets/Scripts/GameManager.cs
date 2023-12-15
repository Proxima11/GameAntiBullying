using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using StarterAssets;

// #if ENABLE_INPUT_SYSTEM 
// using UnityEngine.InputSystem;
// #endif

// [RequireComponent(typeof(CharacterController))]

public class GameManager : MonoBehaviour
{
    // Saving player pos
    public static Vector3 playerPos = new Vector3();
    private GameObject player;
    [SerializeField] private GameObject Task_Object;
    private List<Task_def> coolTasks = new List<Task_def>();
    private List<Task_def> acaTasks = new List<Task_def>();

    void Start(){
        FindObjectOfType<gender>().chooseGender();
        player = GameObject.FindWithTag("Player");
        Debug.Log(player);
        
        Scene scene = SceneManager.GetActiveScene();

        if (playerPos != Vector3.zero && scene.name == "Lorong") // Check if playerPos has been set
        {
            Debug.Log("Restoring player position");
            player.transform.position = playerPos;
        }
        else
        {
            Debug.Log("Player position not saved.");
        }
        Debug.Log(playerPos);

        GameObject academic = Task_Object.transform.GetChild(0).gameObject;
        GameObject coolness = Task_Object.transform.GetChild(1).gameObject;

        Task_def[] aca = academic.GetComponents<Task_def>();
        Task_def[] cool = coolness.GetComponents<Task_def>();

        foreach (var i in aca){
            acaTasks.Add(i);
        }

        foreach (var i in cool){
            coolTasks.Add(i);
        }

        Debug.Log(superScript.idx_acaTasks.Count);
        Debug.Log(superScript.idx_coolTasks.Count);
        if(superScript.idx_acaTasks.Count == 0 && superScript.idx_coolTasks.Count == 0){
            random_tasks();
            FindObjectOfType<InventoryManager>().AddItem(0);
            FindObjectOfType<InventoryManager>().AddItem(1);
            FindObjectOfType<InventoryManager>().AddItem(1);
            FindObjectOfType<InventoryManager>().AddItem(2);
        }
        refreshTask();
    }

    private static bool ws_random_tasks = false;

    private void random_tasks(){
        List<Task_def> temp_coolTasks = new List<Task_def>(coolTasks);
        List<Task_def> temp_acaTasks = new List<Task_def>(acaTasks);

        int empty_util = 0;

        for (int i = 0; i < 7; i++){
            float temp = Random.Range(0f, 1f);  

            if (temp < superScript.nerdCool/100f){
                int rand_util = Random.Range(0, temp_acaTasks.Count-1);
               
                int true_idx = getIndex(temp_acaTasks[rand_util], 0);
                
                superScript.Tasks.Add(acaTasks[true_idx]);
                superScript.idx_acaTasks.Add(true_idx);
                temp_acaTasks.RemoveAt(rand_util);
                Debug.Log("ini nambah task " + acaTasks[true_idx].GetType().Name + " di i ke " + i + " loop pertama");
            } else {
                int rand_util = Random.Range(0, temp_coolTasks.Count-1);
                
                int true_idx = getIndex(temp_coolTasks[rand_util], 1);
                
                superScript.Tasks.Add(coolTasks[true_idx]);
                superScript.idx_coolTasks.Add(true_idx);
                temp_coolTasks.RemoveAt(rand_util);
                Debug.Log("ini nambah task " + coolTasks[true_idx].GetType().Name + " di i ke " + i + " loop pertama");
            }

            if (temp_acaTasks.Count <= 0) {
                empty_util = 1;
                break;
            } else if (temp_coolTasks.Count <= 0) {
                empty_util = 2;
                break;
            }
        }

        int e = 7 - superScript.Tasks.Count;
        if (empty_util == 1){
            for (int i = 0; i < e; i++){
                int rand_util = Random.Range(0, temp_coolTasks.Count-1);

                Debug.Log("ini rand util: " +rand_util);
                
                int true_idx = getIndex(temp_coolTasks[rand_util], 1);

                Debug.Log("ini true index: " +true_idx);
                
                superScript.Tasks.Add(coolTasks[true_idx]);
                superScript.idx_coolTasks.Add(true_idx);
                temp_coolTasks.RemoveAt(rand_util);
                Debug.Log("ini nambah task " + coolTasks[true_idx].GetType().Name + " di i ke " + i + " loop kedua");
            }
            Debug.Log("banyak task: " + superScript.Tasks.Count);
        } else if (empty_util == 2) { 
            Debug.Log("loop kedua sebanyak 7 - " + superScript.Tasks.Count + ": " + (7 - superScript.Tasks.Count));
            for (int i = 0; i < e; i++){
                int rand_util = Random.Range(0, temp_acaTasks.Count-1);

                Debug.Log("ini rand util: " +rand_util);
               
                int true_idx = getIndex(temp_acaTasks[rand_util], 0);

                Debug.Log("ini true index: " +true_idx);
                
                superScript.Tasks.Add(acaTasks[true_idx]);
                superScript.idx_acaTasks.Add(true_idx);
                temp_acaTasks.RemoveAt(rand_util);
                Debug.Log("ini nambah task " + acaTasks[true_idx].GetType().Name + " di i ke " + i + " loop kedua");
            }
            Debug.Log("banyak task: " + superScript.Tasks.Count);
        }
    }

    private int getIndex(Task_def e, int stat){
        switch (stat) {
            case 0:
            for (int i = 0; i < acaTasks.Count; i++){
                if (string.Equals(e.GetType().Name,  acaTasks[i].GetType().Name)) return i;
            }
            break;

            case 1:
            for (int i = 0; i < coolTasks.Count; i++){
                if (string.Equals(e.GetType().Name,  coolTasks[i].GetType().Name)) return i;
            }
            break;

            default:
            return -1;
            break;
        }
        return -1;
    }

    public void refreshTask(){
        List<int> coolTask = new List<int>(superScript.idx_coolTasks);
        List<int> acaTask = new List<int>(superScript.idx_acaTasks);

        foreach(int cool in coolTask){
            if(!superScript.Tasks.Contains(coolTasks[cool])){
                superScript.Tasks.Add(coolTasks[cool]);
            }
        }

        foreach(int aca in acaTask){
            if(!superScript.Tasks.Contains(acaTasks[aca])){
                superScript.Tasks.Add(acaTasks[aca]);
            }
        }
    }

    void Update(){
        // Debug.Log(superScript.time);
    }
    public static Vector3 PlayerPos { get => playerPos; set => playerPos = value; }

    public void starterTask(){

    }

    public void updateSuperScript(){
        //Save Variable
        GameVariable gameVariable = FindObjectOfType<GameVariable>();  
        InventoryManager inventory = FindObjectOfType<InventoryManager>();  

        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
        superScript.itemOnwed = inventory.itemOnwed;
        superScript.itemIndex = inventory.itemIndex;
    }
}

