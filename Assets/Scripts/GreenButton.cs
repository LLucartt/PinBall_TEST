using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour{

  public bool isOnColor;
  public PlayerSwatchScript finalSwatch;
  public bool isPlayer2;
  public GameObject GreenFlare;

  void Start(){
    GreenFlare.SetActive(false);
  }


  void Update(){
    if(isPlayer2 == false){
      if(isOnColor && Input.GetButton("FillColourP1") && finalSwatch.player1GValue <= 254){
        finalSwatch.player1GValue += 1;
        GreenFlare.SetActive(true);
      }
      else{
        GreenFlare.SetActive(false);
      }
    }
    if(isPlayer2 == true){
      if(isOnColor && Input.GetButton("FillColourP2") && finalSwatch.player1GValue <= 254){
        finalSwatch.player1GValue += 1;
        GreenFlare.SetActive(true);
      }
      else{
        GreenFlare.SetActive(false);
      }
    }
  }

  void OnTriggerEnter2D (Collider2D col){
     isOnColor = true;
  }
  void OnTriggerExit2D (Collider2D col){
     isOnColor = false;
     GreenFlare.SetActive(false);
  }
}
