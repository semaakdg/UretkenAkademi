using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundTheSun : MonoBehaviour
{
    public float orbitSpeed = 25; // Güneş etrafında dönme hızı
    public Transform sun; // Güneş nesnesi

    private void Update()
    {
        // Güneş etrafında dönme
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}