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


    GameVariable gameVariable;

    void Start (){
        gameVariable = FindObjectOfType<GameVariable>();  
    }

    void Update (){
        streesBar.value = gameVariable.stress;
        score.SetText(gameVariable.score.ToString());
        time.SetText(gameVariable.minute.ToString() + ":" + gameVariable.second.ToString());
        day.SetText("Day "+gameVariable.day.ToString());
    }   

}
