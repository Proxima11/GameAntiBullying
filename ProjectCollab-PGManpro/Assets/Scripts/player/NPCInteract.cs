using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteract : MonoBehaviour, InterfaceInteractable
{

    public string NPCName;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Interact(Transform interactorTransform)
    {
    }

    public string GetInteractText()
    {
        return "talk with " + NPCName;
    }

    public Transform GetTransform()
    {
        return transform;
    }

}