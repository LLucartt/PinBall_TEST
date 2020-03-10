using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour{
    public GameObject left02;
    public GameObject left01;
    public GameObject right01;
    public GameObject right02;

    public float health = 2;
    SpriteRenderer sr;

    public Color green;
    public Color purple;
    public ScoreScript scoreScript;
    public GameObject currentCreature;
    public GameObject[] prefeb;
    public GameObject Exterminate;
    public GameObject Immortalise;
    public Transform spawner;

    void Start(){
      //green = new Color(138f,207f,132f,132f);
      //purple = new Color(193f,141f,221f,132f);
      //sr = GetComponent<SpriteRenderer>();
    }


    void Update(){
      currentCreature = GameObject.FindWithTag("Creature");
      if(health <= 0){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = purple;
          if(spawnEvent == false){
            scoreScript.player1Score += 1;
            //Destroy(currentCreature);
            StartCoroutine(spawnCreature());
            spawnEvent = true;
          }
        }
      if(health == 1){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = purple;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = purple;
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
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
        }
      if(health >= 4){
        sr = left02.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = left01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right01.GetComponent<SpriteRenderer>(); sr.color = green;
        sr = right02.GetComponent<SpriteRenderer>(); sr.color = green;
          if(spawnEvent == false){
            scoreScript.player2Score += 1;
            //Destroy(currentCreature);
            StartCoroutine(spawnCreature());
            spawnEvent = true;
          }

        }
    }

    IEnumerator spawnCreature(){
        yield return new WaitForSeconds(1f);
        Destroy(currentCreature);
      if(health <= 0){
        health = 2;
        Exterminate.SetActive(true);
        yield return new WaitForSeconds(1f);
      }
      if(health >= 4){
        health = 2;
        Immortalise.SetActive(true);
        yield return new WaitForSeconds(1f);
      }

      yield return new WaitForSeconds(1f);
      Exterminate.SetActive(false);
      Immortalise.SetActive(false);
      int prefeb_num = Random.Range(0,3);
      Debug.Log(prefeb_num);
      Instantiate(prefeb[prefeb_num], spawner);
      spawnEvent = false;

    }
}
