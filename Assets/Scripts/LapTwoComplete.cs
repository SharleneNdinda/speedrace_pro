using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTwoComplete : MonoBehaviour
{
     // will detect the player has crossed the finish line
   void OnTriggerEnter()
   {
       FindObjectOfType<GameManager>().CompleteLevel2();
   }

}
