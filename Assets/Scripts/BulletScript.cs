using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{

    public float speed = 5f;
    Rigidbody2D rb;
    public GameObject Nozzle;

    void Start(){
      rb = GetComponent<Rigidbody2D>();
      Nozzle = GameObject.FindWithTag("P1Nozzle");
      float zRotation = Nozzle.transform.eulerAngles.z;
      this.gameObject.transform.Rotate(this.gameObject.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.x, zRotation);


    }


    void Update(){
      rb.velocity = transform.up * speed;
    }
}
