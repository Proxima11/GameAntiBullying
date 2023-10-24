using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dummyLook : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 camRot = Vector2.zero;
        float maxLook = 50f;
        float sensitivity = 10f;

        camRot.y += Input.GetAxis("Mouse X") * sensitivity;
        camRot.x += Input.GetAxis("Mouse Y") * -1 * sensitivity;

        camRot.x = Mathf.Clamp(camRot.x, maxLook*-1, maxLook);
        camRot.y = Mathf.Clamp( camRot.y, maxLook*-1, maxLook);

        transform.rotation = Quaternion.Euler(new Vector3(camRot.x, camRot.y, 0));


        
    }
}
