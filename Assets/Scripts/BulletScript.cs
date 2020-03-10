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
    public float bulletDam;
    private ConfirmButton ConfirmButton;
    private GameObject confirmButton;

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

      if(isPlayer2 == false){
        confirmButton = GameObject.FindWithTag("P1Confirm");
        ConfirmButton = confirmButton.GetComponent<ConfirmButton>();
      }
      if(isPlayer2){
        confirmButton = GameObject.FindWithTag("P2Confirm");
        ConfirmButton = confirmButton.GetComponent<ConfirmButton>();
      }



    }


    void Update(){
      if(bulletBounceCount >= 6){
        Destroy(gameObject);
      }
      if(ConfirmButton.isSuper == false){
        bulletDam = 1;
      }
      if(ConfirmButton.isSuper == true){
        bulletDam = 2;
      }
    }

    void OnCollisionEnter2D(Collision2D col) {
      if(col.gameObject.tag == "Creature"){
        if(isPlayer2 == false){
          healthBar.health += -bulletDam;
        }
        if(isPlayer2){
          healthBar.health += bulletDam;
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
