using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Total_Persona_Points : MonoBehaviour
{
    public TMP_Text start_points;
    public GameObject[] points;
    private int total_points;
    // Start is called before the first frame update
    void Start()
    {
        total_points=int.Parse(start_points.text);
    }

    // Update is called once per frame
    void Update()
    {
        int temp = total_points;
        for (int i = 1; i <= points.Length; i++){
            temp-=int.Parse(GameObject.Find("Canvas/Personality/Sifat" + i + "/Slider/Score").GetComponent<TMP_Text>().text);
        }
        start_points.text=temp.ToString();
    }
}
