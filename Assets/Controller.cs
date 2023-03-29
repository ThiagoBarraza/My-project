using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public WheelCollider[] wheels;
    
    public float steerPower = 100;
    public float motorPower = 100;
    public Rigidbody rb;
    public GameObject CenterOfMass;


    private void Start()
    {
        rb = GetComponent   <Rigidbody>();
        rb.centerOfMass = CenterOfMass.transform.localPosition;
    }


    void FixedUpdate(){
        
        
        foreach(var wheel in wheels){

            wheel.motorTorque = Input.GetAxis("Vertical") * motorPower;
        }

        for(int i = 0; i < wheels.Length; i++){
            if(i < 2){
                wheels[i].steerAngle = Input.GetAxis("Horizontal") * steerPower;
            }
        }
    }
}
