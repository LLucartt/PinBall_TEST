using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour{

    public float player1Score;
    public float player2Score;
    public TextMeshProUGUI p1s;
    public TextMeshProUGUI p2s;

    void Start(){
      player1Score = 0;
      player2Score = 0;
    }


    void Update(){
      p1s.text =  player1Score.ToString();
      p2s.text =  player2Score.ToString();
    }
}
