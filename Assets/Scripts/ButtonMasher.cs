﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    //Data for class
    public AudioSource clickSound;//Button sound when clicked
    public TextMesh ScoreText;//Display for player's score

    private int score=0;//Numerical data value of our score

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

		
	}//End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Whoooooooooooooooooooooooooooooooop");
    }//End of Update()

    //Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        Debug.Log("OnMickeyMouseDown method clicked");
        //Triggers clicking sound
        clickSound.Play();
        //Increase the score by 1
        score = score + 1;
        //update visual score
        ScoreText.text = score.ToString();
    }//End of OnMouseDown

}//End of Button Masher Class
