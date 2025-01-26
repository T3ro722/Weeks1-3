using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationCurve : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0,1)]//restrict t value
    public float t;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;//time each frame

        if(t>1)
        { t = 0; }//if t>1, resets and loop
       transform.localScale = Vector3.one * curve.Evaluate(t);//calculate t
    }
}
