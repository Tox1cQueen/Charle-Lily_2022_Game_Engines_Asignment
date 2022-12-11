using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody prefab;
    public float randForce;
    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        randForce = Random.Range(400f, 500f);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Spawn();
        }

       // Spawn();
    }

    void Spawn()
    {
        Rigidbody spawn;
        spawn = Instantiate(prefab, pos, Random.rotation) as Rigidbody;
        spawn.AddForce(pos * randForce);
    }
}


