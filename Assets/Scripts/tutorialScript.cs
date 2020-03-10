using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class tutorialScript : MonoBehaviour{
    public GameObject Slide01;
    public GameObject Slide02;
    public GameObject Slide03;
    public GameObject Slide04;
    public GameObject Slide05;
    public GameObject Slide06;
    public GameObject Slide07;
    public GameObject Slide08;
    public GameObject Slide09;
    public GameObject Slide10;
    public TextMeshProUGUI nexttext;

    public bool endTut;
    public bool starttut;

    public float pageNumber;

    void Start(){
      pageNumber = 1;
    }


    void Update(){
      if(Input.GetButtonDown("nextSlide") && !endTut){

        pageNumber += 1;
      }
      if(Input.GetButtonDown("nextSlide") && endTut){
          SceneManager.LoadScene("normalScene");
      }
      if(Input.GetButtonDown("previousSlide") && !starttut){
        pageNumber -= 1;
      }

      if(pageNumber < 1){
        pageNumber = 1;
      }
      if(pageNumber == 1){
        starttut = true;
        Slide01.SetActive(true);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 2){
        starttut = false;
        Slide01.SetActive(false);
        Slide02.SetActive(true);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 3){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(true);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 4){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(true);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 5){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(true);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 6){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(true);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 7){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(true);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 8){
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(true);
        Slide09.SetActive(false);
        Slide10.SetActive(false);
      }
      if(pageNumber == 9){
        nexttext.text = "next";
        endTut = false;
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(true);
        Slide10.SetActive(false);
      }
      if(pageNumber == 10){
        endTut = true;
        nexttext.text = "start";
        Slide01.SetActive(false);
        Slide02.SetActive(false);
        Slide03.SetActive(false);
        Slide04.SetActive(false);
        Slide05.SetActive(false);
        Slide06.SetActive(false);
        Slide07.SetActive(false);
        Slide08.SetActive(false);
        Slide09.SetActive(false);
        Slide10.SetActive(true);
      }
      if(pageNumber > 10){
        pageNumber = 10;
      }
    }


}
