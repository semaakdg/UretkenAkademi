using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxissss : MonoBehaviour
{

    private float deger, deger2;
    // Update is called once per frame
    void Update()
    {
        deger = Input.GetAxis("Horizontal");
        deger2 = Input.GetAxis("Vertical");
        if(deger > 0 )
        {
            print("D veya sa� ok tu�una bast�n�z");
        }
        else if (deger == 0)
        {
            print("Tu�lara basmad�n�z");
        }
        else
        {
            print("A veya sol ok tu�u");
        }

        if (deger2 > 0)
        {
            print("W veya yukar� ok tu�una bast�n�z");
        }
        else if (deger2 == 0)
        {
            print("Tu�lara basmad�n�z");
        }
        else
        {
            print("S veya a�a�� ok tu�u");
        }
    }
}
