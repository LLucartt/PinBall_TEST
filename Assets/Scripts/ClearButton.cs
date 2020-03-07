using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;
  public bool isPlayer2;


  void Start(){

  }


  void Update(){
    if (isPlayer2 == false){
      if(isOnColor && Input.GetKeyDown(KeyCode.E)){
        finalSwatch.player1RValue = (byte)0;
        finalSwatch.player1GValue = (byte)0;
        finalSwatch.player1BValue = (byte)0;
      }
    }
    if (isPlayer2 == true){
      if(isOnColor && Input.GetKeyDown(KeyCode.Keypad0)){
        finalSwatch.player1RValue = (byte)0;
        finalSwatch.player1GValue = (byte)0;
        finalSwatch.player1BValue = (byte)0;
      }
    }
  }

  void OnTriggerEnter2D (Collider2D col){
     isOnColor = true;
  }
  void OnTriggerExit2D (Collider2D col){
     isOnColor = false;
  }
}
