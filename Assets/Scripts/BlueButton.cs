using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;

  void Start(){

  }


  void Update(){
    if(isOnColor && Input.GetKey(KeyCode.E) && finalSwatch.player1BValue <= 254){
      finalSwatch.player1BValue += 1;
    }
  }

  void OnTriggerEnter2D (Collider2D col){
     isOnColor = true;
  }
  void OnTriggerExit2D (Collider2D col){
     isOnColor = false;
  }
  }
