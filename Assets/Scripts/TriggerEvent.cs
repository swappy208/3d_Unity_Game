using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour {

    public GameObject lightbulb = null;
    public bool lightSwitchOn = false;
    public AudioClip lightBulbOn = null;

    void OnTriggerEnter(Collider other)
    {
        if (lightSwitchOn)
        {
            lightbulb.SetActive(false);
            lightSwitchOn = false;
            GetComponent<AudioSource>().Stop();
        }
        else if (!lightSwitchOn)
        {
            lightbulb.SetActive(true);
            lightSwitchOn = true;
            GetComponent<AudioSource>().PlayOneShot(lightBulbOn);
        }
    }

}
