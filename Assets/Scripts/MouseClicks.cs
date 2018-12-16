﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClicks : MonoBehaviour 
{
    private Color originalColor = Color.black;
    private void Awake()
    {
        this.originalColor = this.GetComponent<Renderer>().material.color;
    }
    private void OnMouseEnter()
    {
        this.GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseExit()
    {
        this.GetComponent<Renderer>().material.color = originalColor;
    }

}
