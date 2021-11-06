using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformStick : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            transform.parent = other.transform;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}
