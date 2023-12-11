using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gender : MonoBehaviour
{
    public GameObject objectBoy;
    public GameObject objectGirl;
    // public Transform parent;
    // private GameObject g;
    // Start is called before the first frame update
    public void Awake()
    {
    }
    
    public void Start()
    {   
        // chooseGender();
        // float posx = parent.transform.position.x;
        // float posy = parent.transform.position.y;
        // float posz = parent.transform.position.z;
        // if (!superScript.boy){ 
        //     g = Instantiate(objectBoy, new Vector3(posx, posy-0.1f, posz), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)), parent);
        // } else {
        //     g = Instantiate(objectGirl, new Vector3(posx, posy+0.4f, posz), Quaternion.LookRotation(new Vector3(0f, 0f, -180f)), parent);
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void chooseGender(){
        if (superScript.boy) {
            objectBoy.SetActive(true);
        }
        else {
            objectGirl.SetActive(true);
        }
    }
}
