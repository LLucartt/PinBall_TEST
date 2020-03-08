using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class rotateScript : MonoBehaviour {


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
        currentRotate= transform.eulerAngles.z;

        second = second + direction;


       if(isPlayer2){
         if(currentRotate <= 15 && isMovingUp){
           direction = -0.5f;
           isMovingUp = false;
         }
         if(currentRotate >= 165 && isMovingUp == false){
           direction = 0.5f;
           isMovingUp = true;
         }

        if(currentRotate <= 300f){
          Debug.Log("switch now");
          second = second * -1;
        }

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

     }


   }
}
