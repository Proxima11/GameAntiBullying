using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    public int score;
    public void SaveGame()
    {
        GameVariable gameVariable = FindObjectOfType<GameVariable>();
        GameManager gameManager = FindObjectOfType<GameManager>();
        Vector3 playerPosition = GameManager.playerPos;

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/gameData.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(gameVariable, playerPosition);

        gameManager.updateSuperScript();

        data.boy = superScript.boy;
        data.username = superScript.username;
        data.passiveAggresive = superScript.passiveAggresive;
        data.shyConfidence = superScript.shyConfidence;
        data.nerdCool = superScript.nerdCool;
        data.indexDialog = superScript.indexDialog;
        // data.tasks = superScript.Tasks;
        data.items = superScript.itemIndex;

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public void LoadGame()
    {
        string path = Application.persistentDataPath + "/gameData.fun";

        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            superScript.boy = data.boy;
            superScript.username = data.username;
            superScript.passiveAggresive = data.passiveAggresive;
            superScript.shyConfidence = data.shyConfidence;
            superScript.nerdCool = data.nerdCool;
            superScript.indexDialog = data.indexDialog;
            // superScript.Tasks = data.tasks;
            superScript.itemIndex = data.items;

            superScript.setVariable(data.score, data.stress, data.time, data.day);

            // GameManager.playerPos = new Vector3(data.position[0], data.position[1], data.position[2]);
            // Debug.Log(new Vector3(data.position[0], data.position[1], data.position[2]));
            
        } 
        else
        {
            Debug.LogError("Save file not found in " + path);

        }
    }
}