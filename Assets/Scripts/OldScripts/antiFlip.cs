using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antiFlip : MonoBehaviour
{
    int xRotationLimit = 20;
    int yRotationLimit = 20;
    int zRotationLimit = 20;

    void Update()
    {

        if (transform.rotation.eulerAngles.x > xRotationLimit)
        {
            transform.rotation = Quaternion.identity;
        }

        if (transform.rotation.eulerAngles.y > yRotationLimit)
        {
            transform.rotation = Quaternion.identity;
        }

        if (transform.rotation.eulerAngles.z > zRotationLimit)
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
