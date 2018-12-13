using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject spawnType = null;
    public float scaleMin = 0.2f;
    public float scaleMax = 0.5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject obj = Instantiate(spawnType) as GameObject;

            obj.transform.position = this.transform.position;
            obj.AddComponent<Rigidbody>();

            float scaleSize = Random.Range(scaleMin, scaleMax);
            obj.transform.localScale = Vector3.one * scaleSize;

            obj.GetComponent<Rigidbody>().AddRelativeForce(Vector3.back * 100);

            obj.name = "mySphere";
        }
    }
}
