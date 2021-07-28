using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public Vector3 com;
    public Rigidbody rb;

  
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentsteeringAngle;
    private float currentBreakForce;
    private bool isBreaking;

    [SerializeField] private float motorForce;
    [SerializeField] private float breakForce;
    [SerializeField] private float maxSteeringAngle;

    [SerializeField] private WheelCollider FrontLeftCollider;
    [SerializeField] private WheelCollider FrontRightCollider;
    [SerializeField] private WheelCollider RearLeftCollider;
    [SerializeField] private WheelCollider RearRightCollider;

    [SerializeField] private Transform FrontLeftTransform;
    [SerializeField] private Transform FrontRightTransform;
    [SerializeField] private Transform RearLeftTransform;
    [SerializeField] private Transform RearRightTransform;

    void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.centerOfMass = com;
        }

    private void FixedUpdate()
        {
            GetInput();
            HandleMotor();
            handleSteering();
            UpdateWheels();

        }

    public void GetInput()
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical"); 
            isBreaking = Input.GetKey(KeyCode.Space); 

             
     }
        

    private void HandleMotor()
        {
            FrontLeftCollider.motorTorque = verticalInput * motorForce;
            FrontRightCollider.motorTorque = verticalInput * motorForce;
            currentBreakForce = isBreaking ? breakForce : 0f;
            Applybreaking();
         }

    private void Applybreaking()
        {
            FrontRightCollider.brakeTorque = currentBreakForce;
            FrontLeftCollider.brakeTorque = currentBreakForce;
            RearLeftCollider.brakeTorque = currentBreakForce;
            RearRightCollider.brakeTorque = currentBreakForce;
        }

    private void handleSteering()
        {
            currentsteeringAngle = maxSteeringAngle * horizontalInput;
            FrontLeftCollider.steerAngle = currentsteeringAngle;
            FrontRightCollider.steerAngle = currentsteeringAngle;
        }

    private void UpdateWheels()
        {
            UpdateSingleWheel(FrontLeftCollider, FrontLeftTransform);
            UpdateSingleWheel(FrontRightCollider, FrontRightTransform);
            UpdateSingleWheel(RearLeftCollider, RearLeftTransform);
            UpdateSingleWheel(RearRightCollider, RearRightTransform);
        }

  private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    } 
}
