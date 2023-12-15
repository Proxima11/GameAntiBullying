using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    string SceneName;
    [SerializeField] GameObject loadingScreen;
 
    public void changeScene(){
        GameVariable gameVariable = FindObjectOfType<GameVariable>();
        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
        SceneName = TeleportCollisionQuiz.currentSceneName;
        SceneManager.LoadScene(SceneName);
        
    }
}
