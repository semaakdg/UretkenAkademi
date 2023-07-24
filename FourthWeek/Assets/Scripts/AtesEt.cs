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
        // Fare sol týklandýðýnda düþmaný yok etmek için
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            // Kameradan fare pozisyonuna doðru bir ýþýn gönder
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Iþýnla çarpýþma kontrolü
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("düsman"))
                {
                    // Çarpýþtýðýmýz nesne düþman tag'ine sahipse yok edelim
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
