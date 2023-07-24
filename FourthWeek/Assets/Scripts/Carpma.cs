using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpma : MonoBehaviour
{
    //bunlar�n olabilmesi i�in rigidbody kesinlikle olmal� yoksa istedi�imiz sonu�lar� elde edemeyiz
    /*
    private void OnCollisionEnter(Collision collision) // zemine �arpmalar� alg�lar
    {
        print(collision.gameObject.name + "e �arpt�");        
    }*/

    private void OnTriggerEnter(Collider other) //zeminden ge�i�leri alg�lar
    {
        print(other.gameObject.name + " ile temas ger�ekle�ti");
    }
}
