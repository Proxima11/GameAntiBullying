using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Persona : MonoBehaviour
{

    public TMP_Text score;
    public Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text=Mathf.Floor(slide.value*100).ToString();
    }
}
