using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
   
 
   // will detect the player has crossed the finish line
   void OnTriggerEnter()
   {
       FindObjectOfType<GameManager>().CompleteLevel();
   }



}
