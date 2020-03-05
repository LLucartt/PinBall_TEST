using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour{

    public bool isOnColor;
    public PlayerSwatchScript finalSwatch;

    void Start(){

    }


    void FixedUpdate(){
      if(isOnColor && Input.GetKey(KeyCode.E) && finalSwatch.player1RValue <= 254){
        finalSwatch.player1RValue += 1;
      }
    }

    void OnTriggerEnter2D (Collider2D col){
       isOnColor = true;
    }
    void OnTriggerExit2D (Collider2D col){
       isOnColor = false;
    }
}
