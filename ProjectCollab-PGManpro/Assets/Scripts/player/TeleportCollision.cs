using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class TeleportCollision : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;
    // Update is called once per frame
    /*void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log(GetInteractText());
            if (Input.GetKey(KeyCode.F))
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }*/

    public string GetInteractText()
    {
        string text_output = "Go to " + SceneName;
        return text_output;
    }

    private void Awake()
    {
    }

    public void ToggleDoor()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleDoor();
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
