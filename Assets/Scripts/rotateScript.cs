using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotateScript : MonoBehaviour {

    public Transform TrianglePoint;
    //private float second;
    //public float currentRotate;
    private bool change = false;
    private Quaternion startPOS; //Used to stop the lerp from slowing down when getting to the end
    public float timetoLerp = 2; //how Fast the arrow moves up and down
    float timeLerped = 0; //timer
    public bool black; //true if the blaCk hand

    void Start()
    {
        startPOS = TrianglePoint.localRotation;
        change = true;
    }

    void FixedUpdate()
    {
        //second = second + 0.5f;
        /*
        currentRotate= transform.eulerAngles.z;
        //DateTime currentTime = DateTime.Now;


        if(currentRotate <= 300f){
          Debug.Log("switch now");
          second = second * -1;
        }

        if(currentRotate >= 195){
          second = second * -1;
        }
        */

        //float triangleAngle = -360 * (second / 60);
        //TrianglePoint.localRotation = Quaternion.Euler(0,0, triangleAngle - 50);

        timeLerped += Time.deltaTime; //timer

        //White hand
        if (change && !black)
        {
            TrianglePoint.localRotation = Quaternion.Slerp(startPOS, Quaternion.Euler(0, 0, 180), timeLerped / timetoLerp);
        }

        if (!change && !black)
        {
            TrianglePoint.localRotation = Quaternion.Slerp(startPOS, Quaternion.Euler(0, 0, 0), timeLerped / timetoLerp);
        }

        //Black hand
        if (change && black)
        {
            TrianglePoint.localRotation = Quaternion.Slerp(startPOS, Quaternion.Euler(0, 0, -180), timeLerped / timetoLerp);
        }

        if (!change && black)
        {
            TrianglePoint.localRotation = Quaternion.Slerp(startPOS, Quaternion.Euler(0, 0, 0), timeLerped / timetoLerp);
        }

        //Resets going up and down - Called only one
        if (TrianglePoint.rotation.eulerAngles.z == 180)
        {
            startPOS = TrianglePoint.localRotation;
            change = false;
            timeLerped = 0;

        }

        if (TrianglePoint.rotation.eulerAngles.z == 0)
        {
            startPOS = TrianglePoint.localRotation;
            change = true;
            timeLerped = 0;
        }

    }

}
