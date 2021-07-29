using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrig : MonoBehaviour
{
    public GameObject finishTrig;
    public GameObject halfPointTrig;

    void OnTriggerEnter()
    {
        finishTrig.SetActive (true);
        halfPointTrig.SetActive(false); 
    }    
    
}
