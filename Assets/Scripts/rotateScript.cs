using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotateScript : MonoBehaviour{

   public Transform TrianglePoint;
   private float second;
   public float currentRotate;
   public bool isPlayer2;
   public bool isMovingUp;
   public float direction;

   void Start(){
     gameObject.SetActive(false);
     isMovingUp = true;
     direction = 0.5f;
   }

   void FixedUpdate(){

     second = second + direction;

     currentRotate= transform.eulerAngles.z;
     //Debug.Log(currentRotate);

     if(isPlayer2){
       if(currentRotate <= 15 && isMovingUp){
         direction = -0.5f;
         isMovingUp = false;
       }
       if(currentRotate >= 165 && isMovingUp == false){
         direction = 0.5f;
         isMovingUp = true;
       }

       float triangleAngle = -360 * (second/60);
       TrianglePoint.localRotation = Quaternion.Euler(0,0, triangleAngle + 50);
     }



     if(isPlayer2 == false){

       if(currentRotate <= 199 && isMovingUp){
         direction = -0.5f;
         isMovingUp = false;
       }
       if(currentRotate >= 340 && isMovingUp == false){
         direction = 0.5f;
         isMovingUp = true;
       }

       float triangleAngle = -360 * (second/60);
       TrianglePoint.localRotation = Quaternion.Euler(0,0, triangleAngle - 50);

     }


   }

}
