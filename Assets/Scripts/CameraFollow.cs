﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet;

    //run right after instead of before
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offSet;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
