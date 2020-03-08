using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{

    public float speed = 5f;
    Rigidbody2D rb;
    public GameObject Nozzle;
    public bool isPlayer2;

    void Start(){
      rb = GetComponent<Rigidbody2D>();
      if(isPlayer2 == false){
        Nozzle = GameObject.FindWithTag("P1Nozzle");
      }
      if(isPlayer2){
        Nozzle = GameObject.FindWithTag("P2Nozzle");
      }
      float zRotation = Nozzle.transform.eulerAngles.z;
      this.gameObject.transform.Rotate(this.gameObject.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.x, zRotation);



    }


    void Update(){
      rb.velocity = transform.up * speed;
    }
}
