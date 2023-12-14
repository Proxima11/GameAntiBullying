using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollisionQuiz : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;
    public static string currentSceneName;
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject interact;

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
        FindObjectOfType<GameManager>().updateSuperScript();
        interact.SetActive(false);
        loadingScreen.SetActive(true);
        Scene currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        StartCoroutine(LoadLevelAsync(SceneName)); 
        SceneManager.LoadScene(SceneName);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    IEnumerator LoadLevelAsync(string leveltoload)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(SceneName);

        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            //loadingSlider.value = progressValue;
            yield return null;
        }
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
