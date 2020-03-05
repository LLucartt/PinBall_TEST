using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSizeScript : MonoBehaviour{

    private Vector2 currentScale;

    void Awake(){
      currentScale = transform.localScale;
    }

    void Update(){
      }

    void OnTriggerEnter2D (Collider2D col){
       transform.localScale = Vector2.Scale(transform.localScale, new Vector2(1.1f,1.1f));  
    }
    void OnTriggerExit2D (Collider2D col){
       transform.localScale = currentScale;
    }

}
