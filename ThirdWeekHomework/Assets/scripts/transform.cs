using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transform : MonoBehaviour
{
    public Vector3 yon;
    private void Update()
    {
        //GetComponent<Transform>().Translate(yon);

        GetComponent<Transform>().Rotate(yon);
    }
}
