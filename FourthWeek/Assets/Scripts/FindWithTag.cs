using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindWithTag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("New").GetComponent<Light>().intensity = 0;

        //GameObject.FindGameObjectWithTag("New").GetComponent<Light>().color = Color.red;

        GameObject.FindGameObjectWithTag("New").SetActive(false);
        GameObject.FindGameObjectWithTag("New").GetComponent<Light>().color = Color.red;

    }
}
