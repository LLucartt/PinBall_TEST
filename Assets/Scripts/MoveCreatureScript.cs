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

    void Start(){
      movingUp = true;
      movespeed = 0.05f;
    }


    void Update(){

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
