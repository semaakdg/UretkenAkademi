using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRay : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.forward, Color.red); // new Vector3 yerine Vector3.forward ya da benzeri bir þey de yazabiliriz
        Debug.DrawRay(transform.position, transform.forward, Color.red); // Kendimle beraber dönmesini istiyormas eðer transform.forward'ý kullanmam gerek. Vector3 yerine transformu
    }
}
