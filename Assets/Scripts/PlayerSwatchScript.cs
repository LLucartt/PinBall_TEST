using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwatchScript : MonoBehaviour{

    public byte player1RValue;
    public byte player1GValue;
    public byte player1BValue;
    SpriteRenderer SpriteRenderer;

    void Start(){
      SpriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update(){
      SpriteRenderer.color = new Color32(player1RValue, player1GValue, player1BValue, 255);
    }

}
