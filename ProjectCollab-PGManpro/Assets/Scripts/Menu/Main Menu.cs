using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Toggle boy;
    public Toggle girl;
    public TMP_InputField input_field;
    public GameObject objectGirl;
    public GameObject objectBoy;
    private GameObject g;

    public void Start(){
    }

    public void Play(){
        // GameObject.Find("Player").SetActive(false);
        
        SceneManager.LoadScene("Game");
    }

    public void chooseGender(){
        if (boy.isOn){
            superScript.boy = true;         
            g = Instantiate(objectBoy, new Vector3(785.7f, 75.2f, -813.2f), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)));
            // Animator a = g.AddComponent<Animator>();
            // a.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Assets/Player/Animations/idle.controller");
        } else {
            superScript.boy = false;
            g = Instantiate(objectGirl, new Vector3(785.7f, 60.2f, -813.2f), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)));
            // Animator a = g.AddComponent<Animator>();
            // a.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Assets/Player/Animations/idle.controller");
        }
    }

    public void destroyGender(){
        Destroy(g);
    }

    public void Quit(){
        Debug.Log("Quitting. . .");
        Application.Quit();
    }

    public void changeGender(){
        boy.GetComponent<Toggle>().isOn=!boy.GetComponent<Toggle>().isOn;
        girl.GetComponent<Toggle>().isOn=!girl.GetComponent<Toggle>().isOn;
    }

    public void enterUsername(){
        superScript.username = input_field.GetComponent<TMP_InputField>().text;
    }
}
