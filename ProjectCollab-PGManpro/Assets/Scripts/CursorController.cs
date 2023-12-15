using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    private bool isCursorHidden = true;
    bool isPaused;

    void Start()
    {
        // Hide the cursor initially
        Cursor.visible = false;
    }

    void Update()
    {
        isPaused = Pause.isPaused;
        if(isPaused == false) {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                isCursorHidden = false;

                if (isCursorHidden)
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.Confined;
                }
            }
            if (Input.GetKeyUp(KeyCode.LeftAlt))
            {
                isCursorHidden = true;

                if (isCursorHidden)
                {
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.Confined;
                }
            }   
        }
    }
}
