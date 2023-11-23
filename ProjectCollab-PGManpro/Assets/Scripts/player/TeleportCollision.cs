using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollision : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;

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
        GameVariable gameVariable = FindObjectOfType<GameVariable>();  
        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
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
