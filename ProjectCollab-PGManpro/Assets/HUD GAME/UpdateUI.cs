using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    public Slider streesBar; 
    public TMP_Text score;
    public TMP_Text time;
    public TMP_Text day;
    public GameObject taskCanvas;


    GameVariable gameVariable;

    void Start (){
        gameVariable = FindObjectOfType<GameVariable>();  
    }

    void Update (){
        streesBar.value = gameVariable.stress;
        score.SetText(gameVariable.score.ToString());
        string displayMinute = gameVariable.minute.ToString();
        string displaySecond = gameVariable.second.ToString();
        if (gameVariable.minute<10){
            displayMinute = "0" + gameVariable.minute.ToString();
        }
        if (gameVariable.second<10){
            displaySecond = "0" + gameVariable.second.ToString();
        }
        time.SetText(displayMinute + ":" + displaySecond);
        day.SetText("Day "+gameVariable.day.ToString());
    }   

    public void showTask(){
        taskCanvas.SetActive(true);
    }

    public void exitTask(){
        taskCanvas.SetActive(false);
    }
}
