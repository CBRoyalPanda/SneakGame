﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerObject;
    void Update()
    {
        //Basic camera follow script
        Vector3 lookOnObject = playerObject.position - transform.position;
        lookOnObject = playerObject.position - transform.position;
        transform.forward = lookOnObject.normalized;
    }
}