using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MovementFunction {
    SECONDORDER,
    SLERP,
    LERP,
    SMOOTHDAMP,
    TRANSLATE
}

public class MovementFunctions : MonoBehaviour
{
    public Transform target;
    public MovementFunction movementFunction; 
    
    public float speed = 1f;
    public Vector3 refVelocity = Vector3.zero;
    public float smoothTime = 0.3f;

    public float F = 1f, Z = 1f, R = 1f;
    SecondOrderDynamics secondOrderDynamics;

    void Start()
    {
        secondOrderDynamics = new SecondOrderDynamics (F, Z, R, target.position);
    }

    // Update is called once per frame
    void Update()
    {
        switch (movementFunction) {
            case MovementFunction.SECONDORDER : 
                transform.position = secondOrderDynamics.Update (Time.deltaTime, target.position, Vector3.zero);
                break;
            case MovementFunction.SLERP :
                transform.position = Vector3.Slerp(transform.position, target.position, speed * Time.deltaTime);
                break;
            case MovementFunction.LERP :
                transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
                break;
            case MovementFunction.SMOOTHDAMP :
                //transform.position = Vector3.SmoothDamp(transform.position, target.position, ref refVelocity, speed * Time.deltaTime);
                transform.position = Vector3.SmoothDamp(transform.position, target.position, ref refVelocity, smoothTime);
                break;
            case MovementFunction.TRANSLATE :
                transform.Translate (target.position.normalized * speed * Time.deltaTime);
                break;
            default:
                break;   
        } 

    }

    void OnValidate () {
        secondOrderDynamics = new SecondOrderDynamics (F, Z, R, target.position);
    }
}
