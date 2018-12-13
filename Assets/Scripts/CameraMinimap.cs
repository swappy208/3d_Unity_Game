﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMinimap : MonoBehaviour
{

    public Transform target = null;
    public bool followTarget = true;
    public float cameraHeight = 15;

    void Update()
    {
        if (target)
        {
            if (followTarget)
            {
                this.transform.position = new Vector3(target.position.x, cameraHeight, target.position.z);
            }
            else
            {
                this.transform.position = new Vector3(this.transform.position.x, cameraHeight, this.transform.position.z);
            }
        }

    }
}
