using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;

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
    public bool isDialogOnlyOnce = false;
    Transform tr;


    private void Awake()
    {
        animator = GetComponent<Animator>();
        m_MyQuaternion = new Quaternion();
    }

    public void Interact(Transform interactorTransform)
    {
        if (!FindObjectOfType<DialogManager>().stop)
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
    }
    public string GetInteractText()
    {
        if (transform.tag=="Sampah" || transform.tag=="Debris") return "Take " + NPCName;
        return "talk with " + NPCName;
    }

    public Transform GetTransform()
    {
        return transform;
    }
    public void TriggerDialog()
    {
        if (transform.tag == "Sampah") {
            if (superScript.Tasks.Any(x => x is buangSampah)){
            if (!done_kenalan){
                foreach (var e in superScript.Tasks){
                    if (string.Equals(e.id, "c_buangSampah")){
                        e.task();
                        done_kenalan=true;
                        Destroy(gameObject);
                        return;
                    }
                }
            }   
        }
        }

        if (transform.tag == "Debris") {
            if (superScript.Tasks.Any(x => x is bersihinKelas)){
            if (!done_kenalan){
                foreach (var e in superScript.Tasks){
                    if (string.Equals(e.id, "c_bersihinKelas")){
                        e.task();
                        done_kenalan=true;
                        Destroy(gameObject);
                        return;
                    }
                }
            }   
        }
        }

        if (FindObjectOfType<DialogManager>().buttonF != null) { FindObjectOfType<DialogManager>().buttonF.SetActive(false); }
        if (FindObjectOfType<DialogManager>().buttonEsc != null) { FindObjectOfType<DialogManager>().buttonEsc.SetActive(false); }
        string title = FindObjectOfType<NPCManager>().dialogStatus;
        StoryData storyRunning =  SearchStory(title);
        FindObjectOfType<DialogManager>().StartDialogInk(storyRunning.inkJSON);
        if(isStoryExist){
            FindObjectOfType<DialogManager>().currentStoryName = storyRunning.title;
        }else{
            FindObjectOfType<DialogManager>().currentStoryName = "Default";

            if (transform.tag == "Student"){
            if (superScript.Tasks.Any(x => x is kenalanTeman)){
            if (!done_kenalan){
                foreach (var e in superScript.Tasks){
                    if (string.Equals(e.id, "c_kenalanTeman")){
                        e.task();
                        done_kenalan=true;
                        break;
                    }
                }
            }   
        }
        } else if (transform.tag == "Teacher"){
           if (superScript.Tasks.Any(x => x is menyapaGuru)){
            if (!done_kenalan){
                foreach (var e in superScript.Tasks){
                    if (string.Equals(e.id, "c_menyapaGuru")){
                        e.task();
                        done_kenalan=true;
                        break;
                    }
                }
            }   
        } 
        }
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

        private bool done_kenalan = false;

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