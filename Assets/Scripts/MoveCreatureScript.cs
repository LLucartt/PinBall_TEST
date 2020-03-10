using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreatureScript : MonoBehaviour{
    //float speed = 0.1f;
    //float delta = 4f;
    private float movespeed;
    private bool movingUp;
    private bool firstTime = true;
    public float movement;
    private float starttimer;
    private float timer;
    public GameObject HealthBarObject;
    public HealthBarScript healthBar;
    public Sprite dead;
    public Sprite quarterDead;
    public Sprite halfhalf;
    public Sprite QuarterAlive;
    public Sprite alive;

    void Start(){
      movingUp = true;
      movespeed = 0.05f;
      HealthBarObject = GameObject.FindWithTag("HealthBar");
      healthBar = HealthBarObject.GetComponent<HealthBarScript>();
    }


    void Update(){

      if(healthBar.health <= 0){
        GetComponent<SpriteRenderer>().sprite = dead;
      }
      if(healthBar.health == 1){
        GetComponent<SpriteRenderer>().sprite = QuarterAlive;
      }
      if(healthBar.health == 2){
        GetComponent<SpriteRenderer>().sprite = halfhalf;
      }
      if(healthBar.health == 3){
        GetComponent<SpriteRenderer>().sprite = quarterDead;
      }
      if(healthBar.health >= 4){
        GetComponent<SpriteRenderer>().sprite = alive;
      }


      if(movement == 1){
        starttimer = 1f;
        timer = 2f;
        transform.position = new Vector3(transform.position.x, transform.position.y + movespeed);
        StartCoroutine(MoveUpDown());

      }
      if(movement == 2){
        starttimer = 1.5f;
        timer = 3f;
        transform.position = new Vector3(transform.position.x + (movespeed / 1.5f), transform.position.y + (movespeed / 1.5f));
        StartCoroutine(MoveUpDown());
      }
      if(movement == 3){
        starttimer = 1.5f;
        timer = 3f;
        transform.position = new Vector3(transform.position.x + -(movespeed / 1.5f), transform.position.y + (movespeed / 1.5f));
        StartCoroutine(MoveUpDown());
      }


    }

    IEnumerator MoveUpDown(){

      if(movingUp && firstTime){
        yield return new WaitForSeconds(starttimer);
        movespeed = -0.05f;
        movingUp = false;
        firstTime = false;
      }

      if(movingUp){
        yield return new WaitForSeconds(timer);
        movespeed = -0.05f;
        movingUp = false;
      }
      if(movingUp == false){
        yield return new WaitForSeconds(timer);
        movespeed = 0.05f;
        movingUp = true;
      }

    }
}
