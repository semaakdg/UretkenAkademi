using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRay : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.forward, Color.red); // new Vector3 yerine Vector3.forward ya da benzeri bir �ey de yazabiliriz
        Debug.DrawRay(transform.position, transform.forward, Color.red); // Kendimle beraber d�nmesini istiyormas e�er transform.forward'� kullanmam gerek. Vector3 yerine transformu
    }
}
