using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TeleportCollision : MonoBehaviour, InterfaceInteractable
{
    public string SceneName;
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject interact;

    //[SerializeField] private Slider loadingSlider;

    public string GetInteractText()
    {
        string text_output = "Go to " + SceneName;
        return text_output;
    }

    private void Awake()
    {
    }

    public void ToggleDoor()
    {
        //Save Variable
        GameVariable gameVariable = FindObjectOfType<GameVariable>();  
        InventoryManager inventory = FindObjectOfType<InventoryManager>();  

        superScript.setVariable(gameVariable.score,gameVariable.stress, gameVariable.timeNow, gameVariable.day);
        superScript.itemOnwed = inventory.itemOnwed;

        interact.SetActive(false);
        loadingScreen.SetActive(true);
        StartCoroutine(LoadLevelAsync(SceneName));
        SceneManager.LoadScene(SceneName);
    }
    
    IEnumerator LoadLevelAsync(string leveltoload)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(SceneName);

        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            //loadingSlider.value = progressValue;
            yield return null;
        }
    }
    public void Interact(Transform interactorTransform)
    {
        ToggleDoor();
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
