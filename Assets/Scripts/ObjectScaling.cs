using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScaling : MonoBehaviour {

    public float scaleAmount = 3.0f;

    public Vector3 originalScale;

    void Awake()
    {
        originalScale = this.transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            this.transform.localScale = new Vector3(scaleAmount, scaleAmount, scaleAmount);
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            this.transform.localScale = originalScale;
        }
    }
}
