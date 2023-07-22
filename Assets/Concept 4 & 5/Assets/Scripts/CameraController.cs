using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [SerializeField] private Transform target;
    [SerializeField] private float zoomSpeed = 10.0f;

    private Vector3 prevPosition;

    private void Start()
    {
        cam.transform.position = target.position;
        cam.transform.Translate(new Vector3(0, 1, -10));
        cam.fieldOfView = 60f;
    }

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if(scroll != 0f)
            cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - (scroll * zoomSpeed), 40f, 80f);
        
        if(Input.GetMouseButtonDown(0))
            prevPosition = cam.ScreenToViewportPoint(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            Vector3 direction = prevPosition - cam.ScreenToViewportPoint(Input.mousePosition);

            cam.transform.position = target.position;

            cam.transform.Rotate(new Vector3(1, 0, 0), direction.y * 180);
            cam.transform.Rotate(new Vector3(0, 1, 0), -direction.x * 180, Space.World);
            cam.transform.rotation = Quaternion.Euler(Mathf.Clamp(cam.transform.localRotation.eulerAngles.x, 10f, 90f), cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            if(cam.transform.up.y < 0)
                cam.transform.rotation = Quaternion.Euler(90f, cam.transform.eulerAngles.y, cam.transform.eulerAngles.z);
            cam.transform.Translate(new Vector3(0, 0, -10));

            prevPosition = cam.ScreenToViewportPoint(Input.mousePosition);
        }
    }
}
