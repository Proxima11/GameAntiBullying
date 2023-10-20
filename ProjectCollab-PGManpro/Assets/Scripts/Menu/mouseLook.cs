using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLook : MonoBehaviour
{
    private Vector2 camRot = Vector2.zero;

    public float maxLook = 10f;
    public float sensitivity = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camRot.y += Input.GetAxis("Mouse X") * sensitivity;
        camRot.x += Input.GetAxis("Mouse Y") * -1 * sensitivity;

        camRot.x = Mathf.Clamp(camRot.x, maxLook*-1, maxLook);
        camRot.y = Mathf.Clamp( camRot.y, maxLook*-1, maxLook);

        transform.localEulerAngles = new Vector3(camRot.x, camRot.y, 0);
    }
}
