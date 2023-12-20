using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using StarterAssets;
using UnityEngine.SceneManagement;
using System;

public class UpdateUI : MonoBehaviour
{
    public ParticleSystem particleStress;
    public float fillSpeed = 0.5f;
    public Slider streesBar; 
    public TMP_Text score;
    public TMP_Text time;
    public TMP_Text day;
    public TMP_Text navigation;

    public GameObject taskCanvas;
    public GameObject inventory;
    public GameObject gameOver;

    private bool task = false;
    private int growthRate = 2;

    GameVariable gameVariable;
    public GameObject CanvasStressPlus;
    public TMP_Text stressPlus;
    public bool isStress = false;
    public float isStresscounter = 0;


    void Start (){
        gameVariable = FindObjectOfType<GameVariable>();
        particleStress = GameObject.Find("StressParticles").GetComponent<ParticleSystem>();
    }

    public TMP_Text note;

    public Slider stressAkhir;

    public void showGameOver(){
        Time.timeScale = 0;
        gameOver.SetActive(true);
        GameObject isi = gameOver.transform.GetChild(0).gameObject;
        
        GameObject calculations = isi.transform.GetChild(2).gameObject;
        
        int f_score = gameVariable.score;
        int f_task = gameVariable.getSumDone();
        int f_stress = gameVariable.stress;
        int f_day = gameVariable.day;

        calculations.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Score: " + f_score;
        calculations.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "Tasks " + f_task + "/7";
        stressAkhir.value = f_stress;
        
        bool status = (f_score >= 0 && f_task >= 4 && f_stress < 100 && f_day <= 5) ? true : false;

        if (status) {
            isi.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
            isi.transform.GetChild(1).GetChild(1).gameObject.SetActive(false);
        } else {
            isi.transform.GetChild(1).GetChild(0).gameObject.SetActive(false);
            isi.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
        }

        string notes = "";

        if (f_score < 0){
            notes+="Kamu kurang memperhatikan sekolah dan banyak bertindak buruk. Alangkah lebih baik jika dapat tetap memperhatikan sekolah dan memperbaiki sikap terhadap perundungan. ";
        } else if (f_score <= 74) {
            notes+="Kamu sudah berperilaku baik dalam perundungan, tapi dapat diperbaiki lagi untuk masalah sosial dan akademik agar dapat tetap fokus berkuliah dan tidak terjebak dalam perundungan. ";
        } else {
            notes+="Kamu telah berperilaku baik dan dapat menyelesaikan tugas-tugas dengan baik. Tetap pertahankan sifatmu dalam kehidupan agar dapat mengatasi perundungan. ";
        }

        if (f_stress >= 100) {
            notes+="Namun, hati-hati kamu terlalu pasif dan lembek dalam perundungan. Hal ini dapat merugikan dirimu. Belajarlah berdiri untuk dirimu sendiri dan jangan takut untuk melawan perundungan. ";
        } else if (f_stress > 65) {
            notes+="Kamu juga telah menyeimbangkan persekolahan dan melawan kasus perundungan dengan baik. Namun, tetap hati-hati, tetap jaga diri dalam perundungan dan jangan takut untuk membela yang lemah atau dirimu sendiri agar kamu tidak tertekan. ";
        } else {
            notes+="Kamu telah menangani kasus perundungan dengan baik sehingga tidak tertekan. Tetap pertahankan hal tersebut, tapi tetap hati-hati agar kamu tidak terjerumus menjadi perundung juga. ";
        }

        if (f_task < 4){
            notes+="Kamu kurang dapat fokus pada hal lain jika diberikan tugas. Berhati-hatilah dalam hal ini agar kamu tetap dapat menyeimbangkan hidup dalam persekolahan supaya tetap dapat bersekolah dengan baik. ";
        } else {
            notes+="Kamu telah menyelesaikan tugas-tugas dengan baik, dengan arti kamu dapat mengatur kehidupan persekolahan, serta kasus perundungan dengan seimbang. Pertahankan sifat ini dan tingkatkan agar makin sukses kedepannya. ";
        }
        if (f_day > 5)
        {
            notes += "Kamu kurang dapat fokus pada hal lain jika diberikan tugas. Pertimbangkan waktu untuk bersekolah dengan baik dan tidak terlalu terlena dalam kemalasan. ";
        }
            note.text = notes;

        DateTime dt = DateTime.Now;

        SaveLoadAchievements.SaveFile(superScript.username, dt.ToString("dd-MM-yyy"), superScript.boy, status, f_score, f_task, f_stress, notes);
    }

    public void backtoMenu(){
        SceneManager.LoadScene("Menu");
    }

    void Update (){
        if(streesBar.value < gameVariable.stress)
        {
            streesBar.value += fillSpeed;
            if (!particleStress.isPlaying)
            {
                particleStress.Play();
            }
            stressPlus.text = "+" + gameVariable.stressAdded.ToString();
            isStress = true;
            //CanvasStressPlus.SetActive(true);
        }
        else if (streesBar.value > gameVariable.stress)
        {
            streesBar.value -= fillSpeed;
            if (!particleStress.isPlaying)
            {
                particleStress.Play();
            }
            stressPlus.text = gameVariable.stressAdded.ToString();
            isStress = true;
            //CanvasStressPlus.SetActive(true);
        }
        else
        {
            particleStress.Stop();
        }

        if (isStress)
        {
            isStresscounter += Time.deltaTime;
            if (isStresscounter <= 2.0f)
            {
                CanvasStressPlus.SetActive(true);
            }
            else
            {
                CanvasStressPlus.SetActive(false);
                isStress = false;
                isStresscounter = 0f;
            }
        }
        //streesBar.value = gameVariable.stress;

        if (score.text != "xxx")
        {
            int scores = int.Parse(score.text);
            if (scores < gameVariable.score && gameVariable.takescore == true)
            {
                scores += growthRate;
                score.text = scores.ToString();
                //scorePlus.text = "+" + gameVariable.scoreAdded.ToString();
                //CanvasScorePlus.SetActive(true);
               
            }
            else if (scores > gameVariable.score && gameVariable.takescore == true)
            {
                scores -= growthRate;
                score.text = scores.ToString();
                //scorePlus.text = gameVariable.scoreAdded.ToString();
                //CanvasScorePlus.SetActive(true);
            }
            else
            {
                score.SetText(gameVariable.score.ToString());
                gameVariable.takescore = false;
                //CanvasScorePlus.SetActive(false);
            }
        }
        else
        {
            score.text = "0";
        }
        //score.SetText(gameVariable.score.ToString());
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
            GameObject newT = (GameObject) Instantiate(task_text, scrollview.transform);
            // newT.transform.SetParent(scrollview.transform);
            newT.GetComponent<TMPro.TextMeshProUGUI>().text = (i+1) + ". ";
            if (node.done) newT.GetComponent<TMPro.TextMeshProUGUI>().text += "<s>";
            newT.GetComponent<TMPro.TextMeshProUGUI>().text += node.taskName;
            if (node.done) newT.GetComponent<TMPro.TextMeshProUGUI>().text += "</s>";
        }
    }

    public void exitTask(){
        foreach (Transform c in scrollview.transform)
        {
        Destroy(c.gameObject);
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
