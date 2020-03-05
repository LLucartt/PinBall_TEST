using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;

  void Start(){

  }


  void Update(){
    if(isOnColor && Input.GetKeyDown(KeyCode.E)){
      finalSwatch.player1RValue = (byte)0;
      finalSwatch.player1GValue = (byte)0;
      finalSwatch.player1BValue = (byte)0;
    }
  }

  void OnTriggerEnter2D (Collider2D col){
     isOnColor = true;
  }
  void OnTriggerExit2D (Collider2D col){
     isOnColor = false;
  }
}
