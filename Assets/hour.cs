using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += 0.1f;
        transform.eulerAngles = rot;
    }
}
