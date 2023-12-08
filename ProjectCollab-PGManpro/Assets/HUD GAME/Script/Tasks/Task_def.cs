using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Task_def : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract string taskName{ get;}
    public abstract bool done{ get; set;}
}
