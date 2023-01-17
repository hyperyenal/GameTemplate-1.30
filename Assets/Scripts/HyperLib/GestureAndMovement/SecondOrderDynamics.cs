using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondOrderDynamics 
{
    private Vector3 xp; // previous input
    private Vector3 y, yd; // position and velocity, state variables
    private float k1, k2, k3;


    public SecondOrderDynamics(float f, float z, float r, Vector3 x0)
    {
        // now, constants
        k1 = z / (Mathf.PI * f);
        k2 = 1 / ((2 * Mathf.PI * f) * (2 * Mathf.PI * f));
        k3 = r * z / (2 * Mathf.PI * f);

        // Initialization
        xp = x0;
        y = x0;
        yd = Vector3.zero;
        
    }


    public Vector3 Update(float T, Vector3 x, Vector3 xd)
    {
        if (xd == Vector3.zero) {
            xd = (x - xp) / T;
            xp = x;
        }
        y = y + T * yd;
        yd = yd + T * (x + k3*xd - y - k1*yd) / k2;
        return y;
    }
}
