using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] GameObject player;
    private bool pindah = true;

    private string tp;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Scene scene = SceneManager.GetActiveScene();
            Debug.Log(scene.name);


            if(scene.name == "Lorong lt 1"){           
                GameManager.PlayerPos = player.transform.position;
            }


            InterfaceInteractable interactable = GetInteractableObject();
            if (interactable != null)
            {
                interactable.Interact(transform);
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