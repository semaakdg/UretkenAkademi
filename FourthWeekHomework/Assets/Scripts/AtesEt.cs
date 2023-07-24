using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEt : MonoBehaviour
{
    /*
    RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, Mathf.Infinity)) 
            {
                if(hit.collider.gameObject.tag == "düsman")
                {

                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }*/
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("düsman"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
