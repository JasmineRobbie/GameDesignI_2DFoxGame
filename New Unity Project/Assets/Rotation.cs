using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotZ;
    private float rotationSpeed;
    private bool clockwiseRotation;

    void Update()
    {
        if(!clockwiseRotation)
        {
            rotZ == Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotZ += -Time.deltaTime * rotationSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
