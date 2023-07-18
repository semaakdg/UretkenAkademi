using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, -1.6f, 0f);
    }
}

/*
 * buda kullanýlabilir ama bana daha uzun gibi geldi o yüzden kullanmadým.
    public float rotationSpeed; 
    public Transform sun;

    void Update()
    {
        // Gezegenin kendi etrafýnda dönmesi
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);

        // Güneþ etrafýnda dönme
        if (sun != null)
        {
            transform.RotateAround(sun.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
*/

