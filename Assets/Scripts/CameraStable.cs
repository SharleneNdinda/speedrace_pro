using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    
    public GameObject Car;
    public float CarX;
    public float CarY;
    public float CarZ
    ;
    // Update is called once per frame
    void Update()
    {
        CarX = Car.transform.eulerAngles.x; // access transform component x variable
        CarY = Car.transform.eulerAngles.y; // access transform component y variable
        CarZ = Car.transform.eulerAngles.z; // access transform component y variable


        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
    }
}
