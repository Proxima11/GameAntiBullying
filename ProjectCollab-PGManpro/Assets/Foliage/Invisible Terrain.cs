using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ilangin bagian bawah terrain
        GetComponent<Terrain>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
