using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCounter : MonoBehaviour
{

    public GameObject CountDown;
    public GameObject LapTimer;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (CountStart()); //starts the begginer timer
    }

   IEnumerator CountStart()
   {
       yield return new WaitForSeconds(0.5f);
       CountDown.GetComponent<Text> ().text = "3";
     

       yield return new WaitForSeconds(1);
       CountDown.SetActive(false); // sets the text to not active and decreases the counter

       CountDown.GetComponent<Text> ().text = "2";
       CountDown.SetActive(true); // sets the text to active after decreasing counter

       yield return new WaitForSeconds(1);
       CountDown.SetActive(false); // sets the text to not active and decreases the counter
       CountDown.GetComponent<Text> ().text = "1";
       CountDown.SetActive (true); // sets the text to active after decreasing counter

       yield return new WaitForSeconds(1);
       CountDown.SetActive(false); // sets the text to not active and decreases the counter
       CountDown.GetComponent<Text> ().text = "Go";
       CountDown.SetActive(true); // sets the text to active after decreasing counter


       yield return new WaitForSeconds(1);
       CountDown.SetActive(false); // sets the text to not active and decreases the counter
       LapTimer.SetActive(true); 
   }
}
