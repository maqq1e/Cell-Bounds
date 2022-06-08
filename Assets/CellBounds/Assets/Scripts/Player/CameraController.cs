using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedMovement = 20f;
    public float scrollSpeed = 20f;

    public float arenaSize = 128;

    float cameraRotation = 60;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        
        if (Input.GetAxis("Fire2") == 1)
        {
            pos.x = pos.x + Input.GetAxis("Mouse X") * -1;
            pos.z = pos.z + Input.GetAxis("Mouse Y") * -1;
        }

        pos.y += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime * -1;
        Camera.main.fieldOfView += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime * -1;
        cameraRotation += Input.GetAxis("Mouse ScrollWheel") * scrollSpeed * Time.deltaTime * -1;


        pos.y = Mathf.Clamp(pos.y, 10f, 60.1f);
        pos.x = Mathf.Clamp(pos.x, 0f, arenaSize);
        pos.z = Mathf.Clamp(pos.z, 0f, arenaSize);
        cameraRotation = Mathf.Clamp(cameraRotation, 21f, 80f);
        Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 40f, 80f);

        transform.eulerAngles = new Vector3(cameraRotation, 0, 0);
        
        transform.position = pos;
    }
}
