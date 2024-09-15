using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    public float x = 0;
    public float y = 0;

    public float amplitude = 1;
    public float frequency = 3; 
    public float time = 0;  

    void FixedUpdate()
    {
        float dt = Time.fixedDeltaTime; 

        x = x + (-Mathf.Sin(time * amplitude) * amplitude * frequency * dt);
        y = y + (-Mathf.Cos(time * amplitude) * amplitude * frequency * dt);  

        transform.position = new Vector3(x, y, transform.position.z); 
        
        time += dt; 
    }

    // Homework: Modify x and y to use sin and cos as indicated in the lab document

}
