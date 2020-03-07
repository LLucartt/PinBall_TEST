using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;
  public bool isPlayer2;

  void Start(){

  }


  void Update(){
    if(isPlayer2 == false){
      if(isOnColor && Input.GetKey(KeyCode.E) && finalSwatch.player1BValue <= 254){
        finalSwatch.player1BValue += 1;
      }
    }
    if(isPlayer2 == true){
      if(isOnColor && Input.GetKey(KeyCode.Keypad0) && finalSwatch.player1BValue <= 254){
        finalSwatch.player1BValue += 1;
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
