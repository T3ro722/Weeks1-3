using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CloudsLerp : MonoBehaviour
{

    float cspeed = 0.003f; //the speed of clouds
    public float resetcloudpx = 20; //cloud position resets when the x value reaches x=20
    public float startcloudpx = -20; //cloud position's starting position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //current position
        Vector3 cpos = transform.position;

        //if clouds reaches reset value, reset to starting position
        if (cpos.x > resetcloudpx)
        {
            cpos.x = startcloudpx; //starting position
        }
        else
        {
            //transform continuously
            cpos.x += cspeed;
        }

        //update position
        transform.position = cpos;
    }

  
}
