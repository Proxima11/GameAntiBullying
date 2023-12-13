using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using StarterAssets; 

public class MainMenu : MonoBehaviour
{
    public Toggle boy;
    public Toggle girl;
    public TMP_InputField input_field;
    public GameObject objectGirl;
    public GameObject objectBoy;
    public GameObject pos;
    public Slider sliderValue_PA;
    public Slider sliderValue_SC;
    public Slider sliderValue_NC;


    private GameObject g;
    public void Start(){
    }

    public void fixSlider(){
        Debug.Log("skala: " +sliderValue_NC.GetComponent<Slider>().value);
        superScript.passiveAggresive =sliderValue_PA.GetComponent<Slider>().value;
        superScript.shyConfidence    =sliderValue_SC.GetComponent<Slider>().value;
        superScript.nerdCool         =sliderValue_NC.GetComponent<Slider>().value;
        superScript.day              = 1;
        superScript.Tasks.Clear();
    }

    public void Play(){
        // GameObject.Find("Player").SetActive(false);
        superScript.resetVariable();
        SceneManager.LoadScene("Lorong");
    }

    public void Load(){
        FindObjectOfType<SaveSystem>().LoadGame();
        SceneManager.LoadScene("Lorong");
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }


    public void chooseGender(){
        if (boy.isOn){
            superScript.boy = true;         
            g = Instantiate(objectBoy, new Vector3(pos.transform.position.x, pos.transform.position.y, pos.transform.position.z), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)));
            // Animator a = g.AddComponent<Animator>();
            // a.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Assets/Player/Animations/idle.controller");
        } else {
            superScript.boy = false;
            g = Instantiate(objectGirl, new Vector3(pos.transform.position.x, pos.transform.position.y, pos.transform.position.z), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)));
            // Animator a = g.AddComponent<Animator>();
            // a.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Assets/Player/Animations/idle.controller");
        }
        g.transform.localScale = new Vector3(pos.transform.localScale.x, pos.transform.localScale.y, pos.transform.localScale.z);
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
