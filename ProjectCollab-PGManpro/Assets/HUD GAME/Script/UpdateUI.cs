using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StarterAssets;

public class UpdateUI : MonoBehaviour
{
    public Slider streesBar; 
    public TMP_Text score;
    public TMP_Text time;
    public TMP_Text day;
    public TMP_Text navigation;

    public GameObject taskCanvas;
    public GameObject inventory;


    private bool task = false;

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
        Task();
    }   

[SerializeField] private GameObject scrollview;
[SerializeField] private GameObject task_text;
    public void showTask(){
        taskCanvas.SetActive(true);
        inventory.SetActive(false);
        FindObjectOfType<StarterAssetsInputs>().inDialogue = true;

        for (var i = 0; i < superScript.Tasks.Count; i++){
            var node = superScript.Tasks[i];
            GameObject newT = (GameObject) Instantiate(task_text);
            newT.transform.SetParent(scrollview.transform);
            newT.GetComponent<TMPro.TextMeshProUGUI>().text = (i+1) + ". ";
            if (node.done) newT.GetComponent<TMPro.TextMeshProUGUI>().text += "<s>";
            newT.GetComponent<TMPro.TextMeshProUGUI>().text += node.taskName;
            if (node.done) newT.GetComponent<TMPro.TextMeshProUGUI>().text += "</s>";
        }
    }

    public void exitTask(){
        for (var i = scrollview.transform.childCount - 1; i >= 0; i--)
        {
        Object.Destroy(scrollview.transform.GetChild(i).gameObject);
        }
        taskCanvas.SetActive(false);
        inventory.SetActive(true);
        FindObjectOfType<StarterAssetsInputs>().inDialogue = false;

    }

    private void Task(){
        if (Input.GetKeyUp(KeyCode.T)){
            Debug.Log("task");
            if (!task){
                showTask();
                task = true;
            } else {
                exitTask();
                task = false;
            }
        }
    }
}
