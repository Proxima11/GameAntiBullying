using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
    public GameObject this_npc;
    private bool isStoryExist;
    Transform tr;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        m_MyQuaternion = new Quaternion();
    }

    public void Interact(Transform interactorTransform)
    {
        Vector3 playerTransform;
        if (superScript.boy)
        {
            playerTransform = GameObject.Find("Boy").transform.position;
        }
        else
        {
            playerTransform = GameObject.Find("Girl").transform.position;
        }
        if (this_npc.GetComponent<NavMeshAgent>() != null)
        {
            this_npc.GetComponent<NavMeshAgent>().isStopped = true;
            animator.SetTrigger("TrBreath");
        }
        float store_y = transform.localEulerAngles.y;
        GetTransform().LookAt(playerTransform);
        
        transform.eulerAngles = new Vector3(0f, transform.localEulerAngles.y, 0f);
        //rotateTowards(playerTransform);
        //var rot = gameObject.transform.localRotation.eulerAngles;
        //rot.Set(0f, transform.rotation.y, transform.rotation.z);
        //transform.localRotation = Quaternion.Euler(rot);
        //this_npc.transform.Rotate(new Vector3(0f, this_npc.transform.rotation.y, 0f));
        TriggerDialog();
        if (!FindObjectOfType<DialogManager>().stop)
        {
            transform.eulerAngles = new Vector3(0f, store_y, 0f);
        }
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
        if(isStoryExist){
            FindObjectOfType<DialogManager>().currentStoryName = storyRunning.title;
        }else{
            FindObjectOfType<DialogManager>().currentStoryName = "Default";
        }
        FindObjectOfType<DialogManager>().NPCPrefab = this_npc;
        FindObjectOfType<DialogManager>().animatorNPC = animator;

        //if (this_npc.GetComponent<NavMeshAgent>() != null)
        //{
        //    this_npc.GetComponent<NavMeshAgent>().isStopped = false;
        //}
        //if (this_npc.GetComponent<NavMeshAgent>() != null & FindObjectOfType<DialogManager>().stop == false)
        //{
        //    this_npc.GetComponent<NavMeshAgent>().isStopped = false;
        //}
    }

    private StoryData SearchStory(string title){
        isStoryExist = false;
        foreach(StoryData storyRunning in story){
            if(storyRunning.title == title){
                isStoryExist = true;
                return storyRunning;
            }
        }
        return story[0];
    }
    protected void rotateTowards(Vector3 to)
    {

        Quaternion _lookRotation =
            Quaternion.LookRotation((to - transform.position).normalized);

        //over time
        transform.rotation =
            Quaternion.Slerp(transform.rotation, _lookRotation, Time.deltaTime * 10f);

        //instant
        transform.rotation = _lookRotation;
        Debug.Log(_lookRotation);
    }
}