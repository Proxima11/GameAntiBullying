using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class TeleportCollisionQuiz : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;
    public static string currentSceneName;
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject interact;
    //private bool done_kenalan = false;
    /*private bool done_kenalan_ips = false;
    private bool done_kenalan_mat = false;
    private bool done_kenalan_indo = false;
    private bool done_kenalan_eng = false;*/

    public string GetInteractText()
    {
        string text_output = "Answer " + SceneName;
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
            if (string.Equals(SceneName, "quiz ips"))
            {
                if (superScript.Tasks.Any(x => x is ips))
                {
                        foreach (var e in superScript.Tasks)
                        {
                            if (string.Equals(e.id, "a_ips") && !e.done)
                            {
                                e.task();
                                superScript.done_quiz[0] = 1;
                                ToggleDoor();
                                return;
                            }
                        }
                }
            }
        
            if (string.Equals(SceneName, "quiz ipa"))
            {
                if (superScript.Tasks.Any(x => x is ipa))
                {
                        foreach (var e in superScript.Tasks)
                        {
                            if (string.Equals(e.id, "a_ipa") && !e.done)
                            {
                                e.task();
                                superScript.done_quiz[1] = 1;
                                ToggleDoor();
                                return;
                            }
                        }
                }
            }

         
            if (string.Equals(SceneName, "quiz mat"))
            {
                if (superScript.Tasks.Any(x => x is mat))
                {
                        foreach (var e in superScript.Tasks)
                        {
                            if (string.Equals(e.id, "a_mat") && !e.done)
                            {
                                e.task();
                                superScript.done_quiz[2] = 1;
                                ToggleDoor();
                                return;
                            }
                        }
                }
            }
        
            if (string.Equals(SceneName, "quiz indo"))
            {
                if (superScript.Tasks.Any(x => x is idn))
                {
                        foreach (var e in superScript.Tasks)
                        {
                            if (string.Equals(e.id, "a_idn") && !e.done)
                            {
                                e.task();
                                superScript.done_quiz[3] = 1;
                                ToggleDoor();
                                return;
                            }
                        }
                }
            }
        
            if (string.Equals(SceneName, "quiz eng"))
            {
                if (superScript.Tasks.Any(x => x is eng))
                {
                        foreach (var e in superScript.Tasks)
                        {
                            if (string.Equals(e.id, "a_eng") && !e.done)
                            {
                                e.task();
                                superScript.done_quiz[4] = 1;
                                ToggleDoor();
                                return;
                            }
                        }
                }
            }
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
