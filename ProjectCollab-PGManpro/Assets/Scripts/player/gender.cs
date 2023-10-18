using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (superScript.boy){
            GameObject.Find("Player/Girl").SetActive(false);
        } else {
            GameObject.Find("Player/Boy").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
