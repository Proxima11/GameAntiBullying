using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using StarterAssets;

// #if ENABLE_INPUT_SYSTEM 
// using UnityEngine.InputSystem;
// #endif

// [RequireComponent(typeof(CharacterController))]

public class GameManager : MonoBehaviour
{
    // Saving player pos
    private static Vector3 playerPos = new Vector3();
    private GameObject player;
   [SerializeField] private List<Task_def> coolTasks;
    [SerializeField] private List<Task_def> acaTasks;

    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");


        if (playerPos != Vector3.zero) // Check if playerPos has been set
        {
            Debug.Log("Restoring player position");
            player.transform.position = playerPos;
        }
        else
        {
            Debug.Log("Player position not saved.");
        }
        Debug.Log(playerPos);

        for (int i = 0; i < 10; i++){
            float temp = Random.Range(0f, 1f);  

            if (temp < superScript.nerdCool/100f){
                int rand_util = Random.Range(0, acaTasks.Count);
                superScript.Tasks.Add(acaTasks[rand_util]);
                acaTasks.RemoveAt(rand_util);
            } else {
                int rand_util = Random.Range(0, coolTasks.Count);
                superScript.Tasks.Add(coolTasks[rand_util]);
                coolTasks.RemoveAt(rand_util);
            }
        }
    }

    void Update(){
        // Debug.Log(superScript.time);
    }
    public static Vector3 PlayerPos { get => playerPos; set => playerPos = value; }

    public void starterTask(){

    }
}

