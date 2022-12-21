using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public float force;
    public Rigidbody rb;
    public AudioSource mainSoundEffect;
    public AudioSource explosion;
    public bool hasExploded = false;
    public float angle;
    public float velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        force = Random.Range(20.0f, 30.0f);
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        mainSoundEffect.Play();
    }

    // Update is called once per frame
    void Update()
    {
        velocity = rb.velocity.y;
        if (velocity <= -3 && hasExploded == false)
        {
            Explode();
        }
    }

    void Explode()
    {
        angle = (Random.Range(-180, 0)) * Mathf.Deg2Rad;
        Vector3 explosionForce = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
        rb.AddForce(explosionForce * 30, ForceMode.Impulse);
        explosion.Play();
        hasExploded = true;
    }
    
}
