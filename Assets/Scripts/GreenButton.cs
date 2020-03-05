using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;

  void Start(){

  }


  void Update(){
    if(isOnColor && Input.GetKey(KeyCode.E) && finalSwatch.player1GValue <= 254){
      finalSwatch.player1GValue += 1;
    }
  }

  void OnTriggerEnter2D (Collider2D col){
     isOnColor = true;
  }
  void OnTriggerExit2D (Collider2D col){
     isOnColor = false;
  }
}
