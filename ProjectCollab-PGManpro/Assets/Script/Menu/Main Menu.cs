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
        // boy = GetComponent<Toggle>();
        // girl = GetComponent<Toggle>();
    }

    public void Play(){
        GameObject.Find("Player").SetActive(false);
        SceneManager.LoadScene("Game");
        
    }

    public void Quit(){
        Debug.Log("Quitting. . .");
        Application.Quit();
    }

    public void changeGender(){
        boy.GetComponent<Toggle>().isOn=!boy.GetComponent<Toggle>().isOn;
        girl.GetComponent<Toggle>().isOn=!girl.GetComponent<Toggle>().isOn;
    }
}
