using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public float speed;
    public bool random = true;
    private float hue;
    private float sat;
    private float vi;
    public MeshRenderer mesh;
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        if (random == true)
        {
            hue = Random.Range(0f, 1f);
        }
        sat = 1;
        vi = 1;
        mesh.material.color = Color.HSVToRGB(hue, sat, vi);
    }


    void Update()
    {
        Color.RGBToHSV(mesh.material.color, out hue, out sat, out vi);
        hue += speed / 10000;
        if (hue >= 1)
        {
            hue = 0;
        }
        sat = 1;
        vi = 1;
        mesh.material.color = Color.HSVToRGB(hue, sat, vi);
    }
}
