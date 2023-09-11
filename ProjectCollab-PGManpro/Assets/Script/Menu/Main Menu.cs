using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Toggle boy;
    public Toggle girl;
    public void Start(){
        boy = GetComponent<Toggle>();
        girl = GetComponent<Toggle>();
    }

    public void Play(){
        SceneManager.LoadScene("Game");
    }

    public void Quit(){
        Debug.Log("Quitting. . .");
        Application.Quit();
    }

    public void changeGender(){
        boy.isOn=!boy.isOn;
        girl.isOn=!girl.isOn;
    }
}
