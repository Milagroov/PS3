using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomBureau : MonoBehaviour
{
    [SerializeField] private float DelayZoom;
    [SerializeField] private float DelayUI;
    public Vector3[] Target;
    public Camera Cam;
    public float Speed;
    private float timeElapsed;
    public Animator transition;
    public bool done = false;

    private void Start()
    {
        Cam = Camera.main;
    }

    public void LateUpdate()
    {
        timeElapsed += Time.deltaTime;


        if (timeElapsed > DelayZoom)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 3, Speed);
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, Target[0], Speed);

            if (done == false)
            {
                transition.SetTrigger("UI");
                done = true;
            }

  
        }


    }
}