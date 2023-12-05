using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophyRotate : MonoBehaviour
{

    float r;

    private Transform awal;
    [SerializeField]
    private GameObject t;
    private float target;
    // Start is called before the first frame update
    void Start(){
        awal= t.transform;
    }

    public void rEnter()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float angle = Mathf.SmoothDampAngle(t.transform.eulerAngles.y, target, ref r, 0.1f);

        t.transform.rotation = Quaternion.Euler(0,angle, 0);
    }

    public void rExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        float angle = Mathf.SmoothDampAngle(awal.transform.eulerAngles.y, 90, ref r, 0.1f);

        t.transform.rotation = Quaternion.Euler(0,angle,0);
    }

    public void ChangeAngle(float target){
        this.target = target;
    }
}
