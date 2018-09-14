using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMasher : MonoBehaviour {

    //Data for class
    public AudioSource clickSound;//Button sound when clicked
    public TextMesh ScoreText;//Display for player's score
    public TextMesh TimerText;//Display for timer
    public float gameLength;//How many seconds the game lasts
    public AudioSource gameOverSound;//sound when game ends
    public TextMesh messageText;//Display message text to the player

    private int score=0;//Numerical data value of our score
    private float timeRemaining = 0;//Numerical time remaining value
    private bool gameRunning = true;

    // Use this for initialization
    void Start () {
        Debug.Log("Start method called");

        timeRemaining = gameLength;

	}//End of Start()
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Whoooooooooooooooooooooooooooooooop");

        //Update the numerical time remaining
        timeRemaining = timeRemaining - Time.deltaTime;
        //Update the visual time remaining
        TimerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        //check if time has run out
        if(timeRemaining<=0)
        {
            //only do if gameover is just hit
            if (gameRunning == true)
            {
                //Play gameoversound
                gameOverSound.Play();

                //show th eplayer their score
                messageText.text = "Time up! Final Score= " + score.ToString();
            }//end of if (gameRunning == true)
            //stop timer
            gameRunning = false;
            //stop game running
            timeRemaining = 0;
        }//end of if time runnning

    }//End of Update()

    //Responds to event from Unity that the object has been clicked
    void OnMouseDown()
    {
        //checks if game is still running
        if (gameRunning == true)
        {
            Debug.Log("OnMickeyMouseDown method clicked");
            //Triggers clicking sound
            clickSound.Play();
            //Increase the score by 1
            score = score + 1;
            //update visual score
            ScoreText.text = score.ToString();
        }//end of if(gameRunning == true)

    }//End of OnMouseDown

}//End of Button Masher Class
