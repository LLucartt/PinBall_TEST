using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColourScript : MonoBehaviour{

    public byte rValue;
    public byte gValue;
    public byte bValue;
    SpriteRenderer SpriteRenderer;

    void Start(){
      SpriteRenderer = GetComponent<SpriteRenderer>();
      RandomiseColour();
    }

    void Update(){
    }

    public void RandomiseColour(){
      rValue = (byte)Random.Range(0,255);
      gValue = (byte)Random.Range(0,255);
      bValue = (byte)Random.Range(0,255);
      SpriteRenderer.color = new Color32(rValue, gValue, bValue, 255);
    }

}
