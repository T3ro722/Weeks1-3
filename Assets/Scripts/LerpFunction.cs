using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpFunction : MonoBehaviour
{
    [Range(0, 1)] //speed of lerp
    public float tc; 

    public Vector3 startc;
    public Vector3 endc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(startc, endc, tc);//lerp function
    }
}
