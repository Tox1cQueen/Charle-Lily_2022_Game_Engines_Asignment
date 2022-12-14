using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnObject : MonoBehaviour
{
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
                if (hit.transform)
                {
                    PrintName(hit.transform.gameObject);
                }
            }
        }
    }

    void PrintName(GameObject go)
    {
        print(go.name);
    }
}
