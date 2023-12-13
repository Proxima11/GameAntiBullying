using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollisionQuiz : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;
    public static string currentSceneName;

    public string GetInteractText()
    {
        string text_output = "Answer the quiz";
        return text_output;
    }

    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ToggleDoor()
    {
        GameVariable gameVariable = FindObjectOfType<GameVariable>();  
        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
        Scene currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        SceneManager.LoadScene(SceneName);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
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
