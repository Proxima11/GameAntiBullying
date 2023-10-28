using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{

    // Update is called once per frame
    private void Update() {
        if (Input.GetKeyDown(KeyCode.F)) {
            InterfaceInteractable interactable = GetInteractableObject();
            if (interactable != null) {
                interactable.Interact(transform);
            }
        }
    }

    public InterfaceInteractable GetInteractableObject() {
        List<InterfaceInteractable> interactableList = new List<InterfaceInteractable>();
        float interactRange = 3f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray) {
            if (collider.TryGetComponent(out InterfaceInteractable interactable)) {
                interactableList.Add(interactable);
            }
        }

        InterfaceInteractable closestInteractable = null;
        foreach (InterfaceInteractable interactable in interactableList) {
            if (closestInteractable == null) {
                closestInteractable = interactable;
            } else {
                if (Vector3.Distance(transform.position, interactable.GetTransform().position) < 
                    Vector3.Distance(transform.position, closestInteractable.GetTransform().position)) {
                    // Closer
                    closestInteractable = interactable;
                }
            }
        }

        return closestInteractable;
    }
}
