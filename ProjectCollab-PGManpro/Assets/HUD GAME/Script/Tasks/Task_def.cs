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
}
