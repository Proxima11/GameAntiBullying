using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task_def : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract string id{get;}
    public abstract string taskName{ get; set;}
    public abstract bool done{ get; set;}
    public abstract void task();
    public void getSnacks(){
         float temp = Random.Range(0f, 1f);  
            if (temp > superScript.shyConfidence/100f){
                int jenisSnack = Random.Range(0, 4);
                FindObjectOfType<InventoryManager>().AddItem(jenisSnack);
            }
        FindObjectOfType<GameVariable>().score += 15;
    }
}
