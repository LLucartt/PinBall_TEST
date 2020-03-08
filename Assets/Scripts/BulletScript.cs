using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour{

    public float speed = 5f;
    Rigidbody2D rb;
    public GameObject Nozzle;
    public bool isPlayer2;
    public float bulletBounceCount;
    public GameObject HealthBarObject;
    public HealthBarScript healthBar;

    void Start(){
      HealthBarObject = GameObject.FindWithTag("HealthBar");
      healthBar = HealthBarObject.GetComponent<HealthBarScript>();
      rb = GetComponent<Rigidbody2D>();
      if(isPlayer2 == false){
        Nozzle = GameObject.FindWithTag("P1Nozzle");
      }
      if(isPlayer2){
        Nozzle = GameObject.FindWithTag("P2Nozzle");
      }
      float zRotation = Nozzle.transform.eulerAngles.z;
      this.gameObject.transform.Rotate(this.gameObject.transform.eulerAngles.x, this.gameObject.transform.eulerAngles.x, zRotation);

      rb.velocity = transform.up * speed;

    }


    void Update(){
      if(bulletBounceCount >= 6){
        Destroy(gameObject);
      }
    }

    void OnCollisionEnter2D(Collision2D col) {
      if(col.gameObject.tag == "Creature"){
        if(isPlayer2 == false){
          healthBar.health += -1;
        }
        if(isPlayer2){
          healthBar.health += 1;
        }
        Destroy(gameObject);
      }

      else{
        Vector2 inNormal = col.contacts[0].normal;
        Vector2 newVelocity = Vector2.Reflect(rb.velocity, inNormal);
        bulletBounceCount += 1;
      }

    }

}
