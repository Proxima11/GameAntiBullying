using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float walk_speed = 100f;
    public float back_speed = 90f;
    public float rotate_speed = 100f;
    public float run_speed = 1.5f;
    public Rigidbody rigid;
    public Transform t;
    public Animator anim;
    private bool run;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            if (Input.GetKey(KeyCode.LeftShift)){
                t.position += t.forward * walk_speed * Time.deltaTime * run_speed;
                if(Input.GetKeyDown(KeyCode.LeftShift)){
                anim.SetTrigger("run");
                anim.ResetTrigger("stand");
                anim.ResetTrigger("back");
                anim.ResetTrigger("walk");
                //steps1.SetActive(true);
              }
            } else {
                t.position += t.forward * walk_speed * Time.deltaTime;
                if(Input.GetKeyUp(KeyCode.LeftShift)){
                anim.SetTrigger("walk");
                anim.ResetTrigger("stand");
                anim.ResetTrigger("back");
                anim.ResetTrigger("run");
                //steps1.SetActive(true);
              }
            }
        }
        if (Input.GetKey(KeyCode.S)){
            t.position += t.forward * -1 * back_speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)){
            t.Rotate(0, -rotate_speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D)){
            t.Rotate(0, rotate_speed * Time.deltaTime, 0);
        }
        if(Input.GetKeyDown(KeyCode.W)){
            anim.SetTrigger("walk");
            anim.ResetTrigger("stand");
            anim.ResetTrigger("back");
            anim.ResetTrigger("run");
            //steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.W)){
			anim.ResetTrigger("walk");
            anim.ResetTrigger("run");
            anim.ResetTrigger("back");
			anim.SetTrigger("stand");
			//steps1.SetActive(false);
		}
        if(Input.GetKeyDown(KeyCode.S)){
			anim.SetTrigger("back");
			anim.ResetTrigger("stand");
            anim.ResetTrigger("run");
            anim.ResetTrigger("walk");
			//steps1.SetActive(true);
		}
		if(Input.GetKeyUp(KeyCode.S)){
			anim.ResetTrigger("walk");
            anim.ResetTrigger("run");
            anim.ResetTrigger("back");
			anim.SetTrigger("stand");
			//steps1.SetActive(false);
		}
    }
}
