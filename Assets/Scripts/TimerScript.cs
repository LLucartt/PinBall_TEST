using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class TimerScript : MonoBehaviour{


  Image timerBar;
  public float maxTime = 120f;
  float timeLeft;
  public GameObject timesUpText;
  public GameObject uiscore;
  public ScoreScript scoreScript;
  public GameObject p1Wins;
  public GameObject p2Wins;
  public GameObject tie;
  public GameObject replay;
  public bool playAgain;

  void Start () {
    timesUpText.SetActive (false);
    timerBar = GetComponent<Image> ();
    timeLeft = maxTime;
    //uiscore = GameObject.FindWithTag("HealthBar");
    //healthBar = HealthBarObject.GetComponent<HealthBarScript>();
    scoreScript = uiscore.GetComponent<ScoreScript>();
    p1Wins.SetActive (false);
    p2Wins.SetActive (false);
    tie.SetActive (false);
    replay.SetActive (false);
    playAgain = false;
  }

  void Update () {
    if (timeLeft >0) {
      timeLeft -= Time.deltaTime;
      timerBar.fillAmount = timeLeft / maxTime;

    } else {
      if(playAgain == false){
        timesUpText.SetActive (true);
        //Time.timeScale = 0;
        StartCoroutine(CalculateWinner());
      }

    }

    if(playAgain && (Input.GetButtonDown("shootP1") || Input.GetButtonDown("shootP2"))){
       SceneManager.LoadScene("Start");
    }
  }

  IEnumerator CalculateWinner(){
    yield return new WaitForSeconds(2f);
    timesUpText.SetActive (false);
    //Debug.Log(scoreScript.player1Score);
      if(scoreScript.player1Score > scoreScript.player2Score){
        p1Wins.SetActive (true);
        replay.SetActive (true);
        playAgain = true;
      }
      if(scoreScript.player1Score < scoreScript.player2Score){
        p2Wins.SetActive (true);
        replay.SetActive (true);
        playAgain = true;
      }
      if(scoreScript.player1Score == scoreScript.player2Score){
        tie.SetActive (true);
        replay.SetActive (true);
        playAgain = true;
      }
  }
}
