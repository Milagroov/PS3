using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CamZoom : MonoBehaviour
{
    public bool ZoomActive = false;
    public Vector3[] Target;
    public Camera Cam;
    public float Speed;

    private void Start()
    {
        Cam = Camera.main;
    }

    public void LateUpdate()
    {
        if (ZoomActive)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 3, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[1], Speed);
        }
        else
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 5, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);
        }
    }

    public void ChangeBool()
    {
        ZoomActive = true;
    }

}
