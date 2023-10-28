using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyControl : MonoBehaviour
{
    private Vector3 s;
    private float walk_speed = 100f;
    private float timeR;
    // Start is called before the first frame update
    void Start()
    {
        s = transform.position;
        timeR = Random.Range(10f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeR > 0) {
            transform.position += transform.forward * walk_speed * Time.deltaTime;
            timeR -= Time.deltaTime;
        } else {
            transform.position = s;
            timeR = Random.Range(10f, 20f);
        }        
    }
}
