using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float walk_speed = 500f;
    public float rotate_speed = 100f;
    public Rigidbody rigid;
    public Transform t;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            t.position += t.forward * walk_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)){
            t.position += Vector3.back * walk_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)){
            t.Rotate(0, -rotate_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            t.Rotate(0, rotate_speed * Time.deltaTime, 0);
        }
    }

    void move(){
       
            
        
    }
}
