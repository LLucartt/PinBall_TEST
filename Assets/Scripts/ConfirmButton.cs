﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
  public TextMeshProUGUI percentageBox;
  public int difred;
  public int difgreen;
  public int difblue;
  public int finalScore;
  public bool isPlayer2;
  public GameObject shooter;
  public GameObject player;
  public bool playerGonnaShoot;
  public GameObject bulletPrefab;
  public GameObject SuperbulletPrefab;
  public GameObject Nozzle;
  public Vector2 NozzleLocation;
  private GameObject Bullet;
  private BulletScript bulletScript;
  public bool isSuper;
  public TextMeshProUGUI uiTextPlank;
  public bool GameStart;
  public TextMeshProUGUI countdownText;
  public GameObject flare;

    void Start(){
      uiTextPlank.text =  "";
      StartCoroutine(gameCountDown());
      flare.SetActive(true);
    }


    void Update(){
      NozzleLocation = Nozzle.transform.position;
      if(GameStart){
        /*
        if(isPlayer2 == false){
          Bullet = GameObject.FindWithTag("P1Bullet");
          bulletScript = Bullet.GetComponent<BulletScript>();
        }
        if(isPlayer2){
          Bullet = GameObject.FindWithTag("p2Bullet");
          bulletScript = Bullet.GetComponent<BulletScript>();
        }
  */
        /*
        minRedPass = originalSwatch.rValue;
        maxRedPass = originalSwatch.rValue;
        minRedPass -= 20;
        maxRedPass += 20;
        if (originalSwatch.rValue >= 235){
          maxRedPass = 255;
        }
        if (originalSwatch.rValue <= 20){
          minRedPass = 0;
        }

        minGreenPass = originalSwatch.gValue;
        maxGreenPass = originalSwatch.gValue;
        minGreenPass -= 20;
        maxGreenPass += 20;
        if (originalSwatch.gValue >= 235){
          maxGreenPass = 255;
        }
        if (originalSwatch.gValue <= 20){
          minGreenPass = 0;
        }

        minBluePass = originalSwatch.bValue;
        maxBluePass = originalSwatch.bValue;
        minBluePass -= 20;
        maxBluePass += 20;
        if (originalSwatch.bValue >= 235){
          maxBluePass = 255;
        }
        if (originalSwatch.bValue <= 20){
          minBluePass = 0;
        }
        */
        if(isPlayer2 == false){
          if(isOnColor && Input.GetButtonDown("FillColourP1") && AnalysingAnswers == false){
            AnalysingAnswers = true;
            percentageBox.text =  finalScore.ToString() + "%";
            if(finalScore >= 95){
              //bulletScript.bulletDam = 2;
              //Debug.Log("Super");
              uiTextPlank.text =  "Super!";
              isSuper = true;
            }
            else{
              isSuper = false;
            }
            if(finalScore >= 80 && (finalSwatch.player1RValue >= 1 || finalSwatch.player1GValue >= 1 || finalSwatch.player1BValue >= 1)){
              //Debug.Log("Shoot");
              uiTextPlank.text =  "Shoot!";
              shooter.SetActive(true);
              player.SetActive(false);
            //  bulletScript.bulletDam = 1;
              playerGonnaShoot = true;
            }

            /*
            if(finalSwatch.player1RValue >= minRedPass && finalSwatch.player1RValue <= maxRedPass){
              Debug.Log("Red Pass");
            }
            if(finalSwatch.player1GValue >= minGreenPass && finalSwatch.player1GValue <= maxGreenPass){
              Debug.Log("green Pass");
            }
            if(finalSwatch.player1BValue >= minBluePass && finalSwatch.player1BValue <= maxBluePass){
              Debug.Log("blue Pass");
            }
            */
            else{
              uiTextPlank.text =  "Fail!";
              Debug.Log("fail");
              originalSwatch.RandomiseColour();
              ResetPlayerSwatch();
            }
            AnalysingAnswers = false;
          }

          if(Input.GetButtonDown("shootP1") && playerGonnaShoot){
              Debug.Log("Shoot");
              StartCoroutine(Shoot());
          }
        }

        if(isPlayer2 == true){
          if(isOnColor && Input.GetButtonDown("FillColourP2") && AnalysingAnswers == false){
            AnalysingAnswers = true;
            percentageBox.text =  finalScore.ToString() + "%";
            if(finalScore >= 95){
            //  bulletScript.bulletDam = 2;
              //Debug.Log("Super");
              uiTextPlank.text =  "Super!";
              isSuper = true;
            }
            else{
              isSuper = false;
            }
            if(finalScore >= 80 && (finalSwatch.player1RValue >= 1 || finalSwatch.player1GValue >= 1 || finalSwatch.player1BValue >= 1)){
              //Debug.Log("Shoot");
              uiTextPlank.text =  "Shoot!";
              shooter.SetActive(true);
              player.SetActive(false);
              //bulletScript.bulletDam = 1;
              playerGonnaShoot = true;
            }

            /*
            if(finalSwatch.player1RValue >= minRedPass && finalSwatch.player1RValue <= maxRedPass){
              Debug.Log("Red Pass");
            }
            if(finalSwatch.player1GValue >= minGreenPass && finalSwatch.player1GValue <= maxGreenPass){
              Debug.Log("green Pass");
            }
            if(finalSwatch.player1BValue >= minBluePass && finalSwatch.player1BValue <= maxBluePass){
              Debug.Log("blue Pass");
            }
            */
            else{
              uiTextPlank.text =  "Fail!";
              Debug.Log("fail");
              originalSwatch.RandomiseColour();
              ResetPlayerSwatch();
            }
            AnalysingAnswers = false;
          }
          if(Input.GetButtonDown("shootP2") && playerGonnaShoot){
              Debug.Log("Shoot");
              StartCoroutine(Shoot());
          }
        }

        difred = originalSwatch.rValue - finalSwatch.player1RValue;
        if(difred < 0){
          difred = -difred;
        }
        difgreen = originalSwatch.gValue - finalSwatch.player1GValue;
        if(difgreen < 0){
          difgreen = -difgreen;
        }
        difblue = originalSwatch.bValue - finalSwatch.player1BValue;
        if(difblue < 0){
          difblue = -difblue;
        }

        finalScore = 100 - ((difred + difgreen + difblue) / 6);
        if(finalScore < 0){
          finalScore = 0;
        }
      }
    }

    void OnTriggerEnter2D (Collider2D col){
       isOnColor = true;
    }
    void OnTriggerExit2D (Collider2D col){
       isOnColor = false;
    }

    IEnumerator Shoot(){
      if(isSuper == false){
        Instantiate(bulletPrefab, NozzleLocation, Quaternion.identity);
      }
      if(isSuper == true){
        Instantiate(SuperbulletPrefab, NozzleLocation, Quaternion.identity);
      }
      playerGonnaShoot = false;
      originalSwatch.RandomiseColour();
      ResetPlayerSwatch();
      player.SetActive(true);
      yield return new WaitForSeconds(1f);
      shooter.SetActive(false);
    }

    public void ResetPlayerSwatch(){
      finalSwatch.player1RValue = (byte)0;
      finalSwatch.player1GValue = (byte)0;
      finalSwatch.player1BValue = (byte)0;
    }

    IEnumerator gameCountDown(){
      countdownText.text = "3";
      yield return new WaitForSeconds(1f);
      countdownText.text = "2";
      yield return new WaitForSeconds(1f);
      countdownText.text = "1";
      yield return new WaitForSeconds(1f);
      countdownText.text = "go";
      GameStart = true;
      yield return new WaitForSeconds(1f);
      countdownText.text = "";
      flare.SetActive(false);
    }
}
