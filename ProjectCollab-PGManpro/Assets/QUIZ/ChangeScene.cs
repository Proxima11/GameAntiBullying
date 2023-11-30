using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string SceneName;

    public void changeScene(){
        GameVariable gameVariable = FindObjectOfType<GameVariable>();
        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
        SceneManager.LoadScene(SceneName);
        SceneManager.LoadScene(SceneName);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
