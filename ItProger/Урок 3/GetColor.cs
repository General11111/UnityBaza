using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColor : MonoBehaviour
{
    public GameObject obj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            obj.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Destroy(obj);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (Input.GetKeyUp(KeyCode.G))
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
