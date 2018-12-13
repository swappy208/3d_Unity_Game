using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour {

    public Cameras cameras;
    public Cameras.CameraState cameraState = Cameras.CameraState.none;


    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player") {
            Debug.Log("******State changed*******");
            cameras.cameraState = Cameras.CameraState.followPosition;
        }
    }
}
