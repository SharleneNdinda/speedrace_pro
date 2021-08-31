using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
      public ProgressBar Pb;
      public int value = 100;
      public int dec = 1;

  // Start is called before the first frame update
    void Start()
    {
        Pb.BarValue = value;
    }

   void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "RoadBlock_D")
        {
            Pb.BarValue -= dec;
        }
        
    }
}
