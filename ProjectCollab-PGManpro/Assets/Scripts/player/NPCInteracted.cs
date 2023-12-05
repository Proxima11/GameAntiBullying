using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StoryData
{
    public TextAsset inkJSON;
    public string title;
}

public class NPCInteracted : MonoBehaviour, InterfaceInteractable
{

    public string NPCName;

    private Animator animator;
    public Transform playerGirl;
    public Transform playerBoy;
    private bool isLookingAtPlayer = false;
    Quaternion m_MyQuaternion;
    float speed = 10.0f;
    public StoryData[] story;

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
        Vector3 playerTransform;
        if (superScript.boy)
        {
            playerTransform = GameObject.Find("Boy").transform.position;
        }
        else
        {
            playerTransform = GameObject.Find("Girl").transform.position;
        }
        GetTransform().LookAt(playerTransform);
        //var targetRotation = Quaternion.LookRotation(playerTransform - (transform.position - gameObject.transform.parent.gameObject.transform.position));
        //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, speed * Time.deltaTime);
        TriggerDialog();

    }

    public string GetInteractText()
    {
        return "talk with " + NPCName;
    }

    public Transform GetTransform()
    {
        return transform;
    }
    public void TriggerDialog()
    {
        string title = FindObjectOfType<NPCManager>().dialogStatus;
        StoryData storyRunning =  SearchStory(title);
        FindObjectOfType<DialogManager>().StartDialogInk(storyRunning.inkJSON);
    }

    private StoryData SearchStory(string title){
        bool isStoryExist = false;
        foreach(StoryData storyRunning in story){
            if(storyRunning.title == title){
                isStoryExist = true;
                return storyRunning;
            }
        }
        return story[0];
    }
}