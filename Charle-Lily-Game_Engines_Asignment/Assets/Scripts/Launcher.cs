using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float force;
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
