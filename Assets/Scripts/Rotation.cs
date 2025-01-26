using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))//if mouse down (constant)
        {
            Vector3 rot = transform.eulerAngles;//euglerAngles for rotating object
            rot.z += 0.1f;//rotating speed
            transform.eulerAngles = rot;//update rotation
        }
    }
}
