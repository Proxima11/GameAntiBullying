using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine.UI;
using System;


public class SaveLoadAchievements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void Awake(){
        Directory.CreateDirectory(Application.streamingAssetsPath + "/Achievement_History");
    }

    public static void SaveFile(string uname, string date, bool isBoy, bool isWin, int score, int tasks, int stress, string notes){
        string destination = Application.streamingAssetsPath  + "/Achievement_History/";
        var info = new DirectoryInfo(destination);
        var fileInfo = info.GetFiles();
        int fileCount = 0;
        foreach (var f in fileInfo) fileCount++;
        fileCount/=2;
        fileCount+=1;

        destination = Application.streamingAssetsPath  + "/Achievement_History/save" + fileCount + ".txt";
		StreamWriter writer = new StreamWriter(destination,true);

		Achievements data = new Achievements( uname,  date,  isBoy,  isWin,  score,  tasks,  stress,  notes);
		string playerToJson = JsonUtility.ToJson(data, true);

        writer.WriteLine(playerToJson);

		writer.Close();
    }

    [SerializeField] private GameObject content_achievements;
    [SerializeField] private GameObject achievements_prefab;

    public void LoadFile(){

        string destination = Application.streamingAssetsPath  + "/Achievement_History/";
        var info = new DirectoryInfo(destination);
        var fileInfo = info.GetFiles();
        int fileCount = 0;
         foreach (var f in fileInfo) fileCount++;
        fileCount/=2;
        for (int i = 1; i <= fileCount; i++) {
            StreamReader reader;
            string tempFileName = destination + "/save" + i + ".txt";
            if(File.Exists(tempFileName)) reader = new StreamReader(tempFileName);
            else
            {
                Debug.LogError("File " + tempFileName + " not found");
                continue;
            }

            Achievements data = JsonUtility.FromJson<Achievements>(reader.ReadToEnd());

            GameObject newA = (GameObject) Instantiate(achievements_prefab, content_achievements.transform);
            newA.transform.GetChild(1).GetComponent<TMP_Text>().text = data.uname;
            newA.transform.GetChild(2).GetComponent<TMP_Text>().text = data.date;
            newA.transform.GetChild(3).GetComponent<TMP_Text>().text = "Score: " + data.score.ToString();
            newA.transform.GetChild(4).GetComponent<Slider>().value = data.stress;
            newA.transform.GetChild(5).GetComponent<TMP_Text>().text = "Tasks " + data.tasks.ToString() + "/7";
            
            if (data.isboy){
                newA.transform.GetChild(6).GetChild(0).gameObject.SetActive(true);
                newA.transform.GetChild(6).GetChild(1).gameObject.SetActive(false);
            } else {
                newA.transform.GetChild(6).GetChild(1).gameObject.SetActive(true);
                newA.transform.GetChild(6).GetChild(0).gameObject.SetActive(false);
            }
                
            if (data.iswin){
                newA.transform.GetChild(7).GetChild(0).gameObject.SetActive(true);
                newA.transform.GetChild(7).GetChild(1).gameObject.SetActive(false);
            } else {
                newA.transform.GetChild(7).GetChild(1).gameObject.SetActive(true);
                newA.transform.GetChild(7).GetChild(0).gameObject.SetActive(false);
            }

            newA.transform.GetComponent<Achievements_util>().setNote(data.notes);

            // newA.transform.SetParent(content_achievements.transform);

            fileCount++;
            reader.Close();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
