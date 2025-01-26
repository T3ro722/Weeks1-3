using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursorcircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;//get mouse position
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);//from screen to world
        mousePos.z = -2.3f;//fixed z value so it's visible
        transform.position = mousePos;//update location of circle
    }
}
