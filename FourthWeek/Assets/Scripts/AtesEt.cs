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
                if(hit.collider.gameObject.tag == "d�sman")
                {

                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }*/
    private void Update()
    {
        // Fare sol t�kland���nda d��man� yok etmek i�in
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            // Kameradan fare pozisyonuna do�ru bir ���n g�nder
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // I��nla �arp��ma kontrol�
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("d�sman"))
                {
                    // �arp��t���m�z nesne d��man tag'ine sahipse yok edelim
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
