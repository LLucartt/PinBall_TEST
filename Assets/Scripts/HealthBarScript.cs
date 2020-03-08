using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour{
    public GameObject left03;
    public GameObject left02;
    public GameObject left01;
    public GameObject right01;
    public GameObject right02;
    public GameObject right03;

    public float health = 2;
    SpriteRenderer sr;

    public Color green;
    public Color purple;

    void Start(){
      //green = new Color(138f,207f,132f,132f);
      //purple = new Color(193f,141f,221f,132f);
      //sr = GetComponent<SpriteRenderer>();
    }


    void Update(){
      if(health <= 0){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
        }
      if(health == 1){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
        }
      if(health == 2){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
        }
      if(health == 3){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
        }
      if(health >= 4){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = purple;
        }

    }
}
