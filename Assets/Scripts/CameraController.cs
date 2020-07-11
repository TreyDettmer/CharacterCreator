using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public float zoomSpeed = 1f;
    public float rotationSpeed = 1f;
    private float xRotation = 0f;
    public Transform bodyTarget;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.RotateAround(bodyTarget.position, Vector3.up, -Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime);
        }
        
        if (Input.GetAxisRaw("Mouse ScrollWheel") != 0)
        {
            if (cam.fieldOfView + Input.GetAxisRaw("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime >= 14 && cam.fieldOfView + Input.GetAxisRaw("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime <= 40)
            {
                cam.fieldOfView += Input.GetAxisRaw("Mouse ScrollWheel") * zoomSpeed * Time.deltaTime;
            }
        }
    }

    public void FocusCamera(int bodyPart)
    {
        if (bodyPart == 3)
        {
            transform.position = new Vector3(transform.position.x, -0.8f, transform.position.z);
            cam.fieldOfView = 20;
        }
        else if (bodyPart == 2)
        {
            transform.position = new Vector3(transform.position.x, -1.46f, transform.position.z);
            cam.fieldOfView = 40;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, -2.17f, transform.position.z);
            cam.fieldOfView = 20;
        }
    }
}
