﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw2dBall : MonoBehaviour
{

    int frameNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("frame number:" + frameNumber);
        frameNumber += 1;
    }
}
