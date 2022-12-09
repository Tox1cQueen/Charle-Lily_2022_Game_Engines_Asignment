using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody prefab;
    public float randRotate;
    public float randForce;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        randForce = Random.Range(400f, 500f);
        randRotate = Random.Range(-180f, 180f);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Rigidbody spawn;
        spawn = Instantiate(prefab, transform.up, transform.rotation) as Rigidbody;
        spawn.AddForce(transform.up * randForce);
    }
}


