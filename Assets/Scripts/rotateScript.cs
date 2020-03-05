using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotateScript : MonoBehaviour{

   public Transform TrianglePoint;
   private float second;
   public float currentRotate;

   void Start(){

   }

   void FixedUpdate(){

     second = second + 0.5f;
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

     float triangleAngle = -360 * (second/60);
     TrianglePoint.localRotation = Quaternion.Euler(0,0, triangleAngle - 50);
   }

}
