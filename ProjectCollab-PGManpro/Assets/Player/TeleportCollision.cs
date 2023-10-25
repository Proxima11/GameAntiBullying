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
           SceneManager.LoadScene(SceneName);
        }
    }
}
