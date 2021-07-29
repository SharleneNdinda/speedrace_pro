using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{

    public float timeValue = 120; 
    public Text timeText;
    public GameObject GameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            GameOverUI.SetActive(false);


        }
        else
        {
            timeValue = 0;
        }

        DisplayTime(timeValue);
    }

        void DisplayTime(float timeToDisplay)
        {
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;

                // sets the game over ui to true and ends the game

                GameOverUI.SetActive(true);
                // FindObjectOfType<GameManager>().EndGame();
                
            }

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            timeText.text = string.Format("Countdown: {0:00}:{1:00}", minutes, seconds);
        }
    
}
