using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmButton : MonoBehaviour{

  public PlayerSwatchScript finalSwatch;
  public RandomColourScript originalSwatch;
  public bool isOnColor;
  public byte minRedPass;
  public byte maxRedPass;
  public byte minGreenPass;
  public byte maxGreenPass;
  public byte minBluePass;
  public byte maxBluePass;
  public bool AnalysingAnswers;
/*
  public byte player1RValue;
  public byte player1GValue;
  public byte player1BValue;

  public byte rValue;
  public byte gValue;
  public byte bValue;
*/
    void Start(){

    }


    void Update(){

      minRedPass = originalSwatch.rValue;
      maxRedPass = originalSwatch.rValue;
      minRedPass -= 20;
      maxRedPass += 20;
      minGreenPass = originalSwatch.gValue;
      maxGreenPass = originalSwatch.gValue;
      minGreenPass -= 20;
      maxGreenPass += 20;
      minBluePass = originalSwatch.bValue;
      maxBluePass = originalSwatch.bValue;
      minBluePass -= 20;
      maxBluePass += 20;

      if(isOnColor && Input.GetKeyDown(KeyCode.E) && AnalysingAnswers == false){
        AnalysingAnswers = true;
        if(finalSwatch.player1RValue >= minRedPass && finalSwatch.player1RValue <= maxRedPass){
          Debug.Log("Red Pass");
        }
        if(finalSwatch.player1GValue >= minGreenPass && finalSwatch.player1GValue <= maxGreenPass){
          Debug.Log("green Pass");
        }
        if(finalSwatch.player1BValue >= minBluePass && finalSwatch.player1BValue <= maxBluePass){
          Debug.Log("blue Pass");
        }
        else{
          Debug.Log("fail");
        }
        AnalysingAnswers = false;
      }
    }

    void OnTriggerEnter2D (Collider2D col){
       isOnColor = true;
    }
    void OnTriggerExit2D (Collider2D col){
       isOnColor = false;
    }
}
