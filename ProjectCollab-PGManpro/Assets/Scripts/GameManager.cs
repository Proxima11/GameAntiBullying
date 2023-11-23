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

        int nAkademik = 0, nCool = 0;
        for (int i = 0; i < 20; i++){
            float temp = Random.Range(0f, 1f);

            if (temp < superScript.nerdCool){
                Debug.Log("task akademik ke " + (i+1));
                nAkademik++;
            } else {
                Debug.Log("task kekerenan ke " + (i+1));
                nCool++;
            }
        }

        Debug.Log("tugas akademik: " + nAkademik + "\ntugas cool: " + nCool);
    }
    public static Vector3 PlayerPos { get => playerPos; set => playerPos = value; }

    public void starterTask(){

    }
}

