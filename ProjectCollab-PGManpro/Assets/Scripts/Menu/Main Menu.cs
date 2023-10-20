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
    public Texture2D cursor;

    public void Start(){
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void Play(){
        // GameObject.Find("Player").SetActive(false);
        SceneManager.LoadScene("Game");
        
    }

    public void chooseGender(){
        if (boy.isOn){
            superScript.boy = true;
        } else {
            superScript.boy = false;
        }
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
