using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float force;
    public Rigidbody rb;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        force = Random.Range(20.0f, 30.0f);
        audioSource = GetComponent<AudioSource>();
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
