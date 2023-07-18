using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundTheEarth : MonoBehaviour
{
    public Transform earth; 
    public float orbitSpeed; 

    void Update()
    {
        transform.RotateAround(earth.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
