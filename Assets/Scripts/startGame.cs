using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public bool tutorial;
    public TextMeshProUGUI tutText;
    // Start is called before the first frame update
    void Start()
    {
        tutorial = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("FillColourP1") || Input.GetButtonDown("FillColourP2")){
          tutorial = !tutorial;
        }

        if(tutorial){
          tutText.text = "yes";
        }
        if(!tutorial){
          tutText.text = "no";
        }

        if(tutorial && (Input.GetButtonDown("shootP1") || Input.GetButtonDown("shootP2"))){
           SceneManager.LoadScene("tutorialScene");
        }
        if(!tutorial && (Input.GetButtonDown("shootP1") || Input.GetButtonDown("shootP2"))){
           SceneManager.LoadScene("normalScene");
        }
    }
}
