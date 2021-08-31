using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public ProgressBar Pb;
    public int value = 100;
    public int dec = 1;

    // Start is called before the first frame update
    void Start()
    {
        Pb.BarValue = value;
    }
    
//   detect collision and reduce life 
     void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Terrain_2")
        {
            Pb.BarValue -= dec;
        }
        
    }
}
