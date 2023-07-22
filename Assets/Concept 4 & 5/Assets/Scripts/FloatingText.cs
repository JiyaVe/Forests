using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingText : MonoBehaviour
{
    Transform cam;
    Transform worldCanvas;

    public Vector3 offset;
    Transform target;

    private void OnEnable()
    {
        target = transform.parent;
        cam = Camera.main.transform;
        worldCanvas = GameObject.FindGameObjectWithTag("WorldCanvas").transform;

        transform.SetParent(worldCanvas);
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - cam.transform.position);
        transform.position = target.position + offset;
    }
}
