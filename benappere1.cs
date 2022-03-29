using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benappere1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Collider>().enabled = true;   
        GetComponent<Renderer>().enabled = true;
    }
}
