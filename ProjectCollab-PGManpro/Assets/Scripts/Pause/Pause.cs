using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StarterAssets;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject canvasPause;
    bool isPaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0;
        canvasPause.SetActive(true);
        FindObjectOfType<StarterAssetsInputs>().inDialogue = true;
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        canvasPause.SetActive(false);
        FindObjectOfType<StarterAssetsInputs>().inDialogue = false;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}