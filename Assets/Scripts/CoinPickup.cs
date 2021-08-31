using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinPickup : MonoBehaviour
{
    
    public float coin = 0;
    public Text CoinCounter;

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.transform.tag == "Coin")
        {
            coin++;
            CoinCounter.text = coin.ToString();
            Destroy(collider.gameObject );
        }
    }
}
