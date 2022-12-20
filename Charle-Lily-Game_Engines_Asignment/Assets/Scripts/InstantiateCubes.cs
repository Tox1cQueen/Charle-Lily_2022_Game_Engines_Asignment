using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public GameObject sampleCube;
    private GameObject[] sampleCubeArray = new GameObject[512];
    public float maxScale;
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject instanceSampleCube = (GameObject)Instantiate(sampleCube);
            instanceSampleCube.transform.position = this.transform.position;
            instanceSampleCube.transform.parent = this.transform;
            instanceSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            instanceSampleCube.transform.position = Vector3.forward * 100;
            sampleCubeArray[i] = instanceSampleCube;
        }
    }
    
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (sampleCubeArray != null)
            {
                sampleCubeArray[i].transform.localScale = new Vector3(1, (Visualiser.samples[i] * maxScale) + 2, 1);
            }
        }
    }
}
