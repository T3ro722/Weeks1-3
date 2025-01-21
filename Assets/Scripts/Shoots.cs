using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += 0.01f;
        transform.position = pos;
    }
}
