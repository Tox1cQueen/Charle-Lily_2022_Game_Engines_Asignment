using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class StringHandler : MonoBehaviour
{

    public string[] toasterObjectCodes;
    public Rigidbody[] toasterObjects;
    public string currentValue = "";
    public float force = 5;
    public Rigidbody testPrefab;
    public Transform spawnLocation;
    private Rigidbody currentToast;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {

                Debug.Log(hit.transform.name);

                if (hit.transform.tag == "Number")
                {
                    currentValue = (currentValue + hit.transform.name);
                }

                if (toasterObjectCodes.Contains(currentValue) && hit.transform.name == "Enter")
                {
                    int index = Array.IndexOf(toasterObjectCodes, currentValue);
                    currentToast = toasterObjects[index];
                    Vector3 Spawnpoint = new Vector3(spawnLocation.position.x, spawnLocation.position.y,
                        spawnLocation.position.z);
                    Instantiate(currentToast, Spawnpoint, Random.rotation);
                    currentValue = "";
                }

                else if (hit.transform.name == "Enter")
                {
                    currentValue = "";
                }
            }
        }
    }

    void PrintName(GameObject go)
    {
        print(go.name);
    }
}
    
 