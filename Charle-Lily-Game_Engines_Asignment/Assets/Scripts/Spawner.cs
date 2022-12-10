using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Rigidbody prefab;
    public Vector3 randRotate;
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
        randRotate = new Vector3(Random.Range(-180f, 180f), Random.Range(-180f, 180f), Random.Range(-180f, 180f));

        if (Input.GetKeyDown(KeyCode.E))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Rigidbody spawn;
        spawn = Instantiate(prefab, pos, Random.rotation) as Rigidbody;
        spawn.AddForce(pos * randForce);
    }
}


