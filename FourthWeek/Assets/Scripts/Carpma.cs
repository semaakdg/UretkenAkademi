using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    //bunlarýn olabilmesi için rigidbody kesinlikle olmalý yoksa istediðimiz sonuçlarý elde edemeyiz
    /*
    private void OnCollisionEnter(Collision collision) // zemine çarpmalarý algýlar
    {
        print(collision.gameObject.name + "e çarptý");        
    }*/

    private void OnTriggerEnter(Collider other) //zeminden geçiþleri algýlar
    {
        print(other.gameObject.name + " ile temas gerçekleþti");
    }
}
