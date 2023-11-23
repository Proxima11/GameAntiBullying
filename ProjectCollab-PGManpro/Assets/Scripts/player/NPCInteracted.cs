using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteracted : MonoBehaviour, InterfaceInteractable
{

    public string NPCName;

    private Animator animator;
    public Transform playerGirl;
    public Transform playerBoy;
    private bool isLookingAtPlayer = false;
    Quaternion m_MyQuaternion;
    float m_Speed = 1.0f;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        m_MyQuaternion = new Quaternion();
        //npcHeadLookAt = GetComponent<NPCHeadLookAt>();
    }

    public void Interact(Transform interactorTransform)
    {
        //float playerHeight = 1f;
        //sLookingAtPlayer = !isLookingAtPlayer;

        //if (isLookingAtPlayer)
        //{
        //LookAtPlayer();
        //}
        //else
        //{
        //LookBack();
        //}
        //m_MyQuaternion.SetFromToRotation(transform.position, playerTransform.position);
        //transform.rotation = m_MyQuaternion * transform.rotation;
        Transform playerTransform = null;
        if (playerGirl != null)
        {
            playerTransform = playerGirl;
        }
        else
        {
            playerTransform = playerBoy;
        }
        GetTransform().LookAt(playerTransform);
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
