using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportCollision : MonoBehaviour
{
    public string SceneName;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            System.Console.WriteLine(GetInteractText());
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(SceneName);
            }
        }
    }

    public string GetInteractText()
    {
        string text_output = "Go to " + SceneName;
    return text_output;
    }
}
