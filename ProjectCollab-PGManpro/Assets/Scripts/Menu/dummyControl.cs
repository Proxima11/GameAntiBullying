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
        timeR = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    public float minTime = 10f;
    public float maxTime = 20f;
    void Update()
    {
        if (timeR > 0) {
            transform.position += transform.forward * walk_speed * Time.deltaTime;
            timeR -= Time.deltaTime;
        } else {
            transform.position = s;
            timeR = Random.Range(minTime, maxTime);
        }        
    }
}
