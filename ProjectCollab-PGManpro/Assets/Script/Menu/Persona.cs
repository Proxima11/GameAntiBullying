using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Persona : MonoBehaviour
{
    public Slider slide;
    public TMP_Text type;
    int pointType;
    // Start is called before the first frame update
    void Start()
    {
        if (string.Equals(type.text.ToString(), "Passive")){
            pointType = 1;
        } else if (string.Equals(type.text.ToString(), "Shy")) {
            pointType = 2;
        } else if (string.Equals(type.text.ToString(), "Nerd")) {
            pointType = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (pointType==1) {
        superScript.passiveAggresive=(int) Mathf.Floor(slide.value*100);
        } else if (pointType==2) {
        superScript.shyConfidence=(int) Mathf.Floor(slide.value*100);
        } else if (pointType==3) {
        superScript.nerdCool=(int) Mathf.Floor(slide.value*100);
        } 
    }
}
