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

        if (!ws_random_tasks){
            random_tasks();
            ws_random_tasks = true;
        }
    }

    private static bool ws_random_tasks = false;

    private void random_tasks(){
        GameObject academic = Task_Object.transform.GetChild(0).gameObject;
        GameObject coolness = Task_Object.transform.GetChild(1).gameObject;

        // for (int i = 0; i < academic.transform.childCount; i++){
        //     acaTasks.Add(academic.transform.GetChild(i).GetComponents<Task_def>());
        // }

        // for (int i = 0; i < coolness.transform.childCount; i++){
        //     coolTasks.Add(coolness.transform.GetChild(i).GetComponents<Task_def>());
        // }

        Task_def[] aca = academic.GetComponents<Task_def>();
        Task_def[] cool = coolness.GetComponents<Task_def>();

        foreach (var i in aca){
            acaTasks.Add(i);
        }

        foreach (var i in cool){
            coolTasks.Add(i);
        }

        for (int i = 0; i < 4; i++){
            float temp = Random.Range(0f, 1f);  

            if (temp < superScript.nerdCool/100f){
                int rand_util = Random.Range(0, acaTasks.Count-1);
                // while (superScript.idx_acaTasks.Contains(rand_util)){
                //     rand_util = Random.Range(0, acaTasks.Count-1);
                // }
                rand_util = i;
                
                superScript.Tasks.Add(acaTasks[rand_util]);
                superScript.idx_acaTasks.Add(rand_util);
            } else {
                int rand_util = Random.Range(0, coolTasks.Count-1);
                // while (superScript.idx_coolTasks.Contains(rand_util)){
                //     rand_util = Random.Range(0, coolTasks.Count-1);
                //     Debug.Log("ini random: " + rand_util);
                //     Debug.Log("ini isi list:");
                //     foreach (int x in superScript.idx_coolTasks){
                //         Debug.Log(x);       
                //     }
                // }
                rand_util = i;
                
                superScript.Tasks.Add(coolTasks[rand_util]);
                superScript.idx_coolTasks.Add(rand_util);
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

