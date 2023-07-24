using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        //print(Input.GetKey(KeyCode.Space)); // 0 = sol, 1 = sað, 2 = orta ( mouseda)
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Light>().intensity = 100f;
        }
    }
}
