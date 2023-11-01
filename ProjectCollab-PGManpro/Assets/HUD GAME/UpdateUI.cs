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


    PlayerStats playerStats;

    void Start (){
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
    }

    void Update (){
        streesBar.value = playerStats.stress;
        score.SetText(playerStats.score.ToString());
        time.SetText(playerStats.minute.ToString() + ":" + playerStats.second.ToString());
        day.SetText("Day "+playerStats.day.ToString());
    }   

}
