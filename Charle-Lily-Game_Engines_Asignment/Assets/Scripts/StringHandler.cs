using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringHandler : MonoBehaviour
{

    public string currentValue = "";
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject enterButton;
    

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
                if (hit.transform.name == "1")
                {
                    currentValue = (currentValue + "1");
                }

                if (hit.transform.name == "2")
                {
                    currentValue = (currentValue + "2");
                }

                if (hit.transform.name == "3")
                {
                    currentValue = (currentValue + "3");
                }

                if (hit.transform.name == "Enter")
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
