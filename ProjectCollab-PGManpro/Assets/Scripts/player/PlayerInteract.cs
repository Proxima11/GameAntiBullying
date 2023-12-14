using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] GameObject player;

    private TeleportCollision teleportCollision;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        GameObject gameObjectScene = new GameObject("TeleportCollision");
        teleportCollision = gameObjectScene.AddComponent<TeleportCollision>();
        gameObjectScene.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Scene scene = SceneManager.GetActiveScene();
            Debug.Log(scene.name);
            Debug.Log("pressed");

            if (scene.name == "Lorong lt 1" || scene.name == "Lorong")
            {
                GameManager.PlayerPos = player.transform.position;
                FindObjectOfType<NPCManager>().randomEvent = false;
            }

            InterfaceInteractable interactable = GetInteractableObject();
            if (interactable != null)
            {
                interactable.Interact(transform);
                // FindObjectOfType<GameVariable>().TakeStress(1);
            }
        }
    }

    public InterfaceInteractable GetInteractableObject()
    {
        List<InterfaceInteractable> interactableList = new List<InterfaceInteractable>();
        float interactRange = 1f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out InterfaceInteractable interactable))
            {
                interactableList.Add(interactable);
            }
        }

        InterfaceInteractable closestInteractable = null;
        foreach (InterfaceInteractable interactable in interactableList)
        {
            if (closestInteractable == null)
            {
                closestInteractable = interactable;
            }
            else
            {
                if (Vector3.Distance(transform.position, interactable.GetTransform().position) <
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position))
                {
                    // Closer
                    closestInteractable = interactable;
                }
            }
        }

        return closestInteractable;
    }

}