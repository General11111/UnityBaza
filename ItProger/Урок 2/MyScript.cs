using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    [SerializeField]
    private float abc = 23.45f;
    void Start()
    {
        Show();
    }

    
    void Show()
    {
        print(abc);
    }
}
