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
            print("D veya sað ok tuþuna bastýnýz");
        }
        else if (deger == 0)
        {
            print("Tuþlara basmadýnýz");
        }
        else
        {
            print("A veya sol ok tuþu");
        }

        if (deger2 > 0)
        {
            print("W veya yukarý ok tuþuna bastýnýz");
        }
        else if (deger2 == 0)
        {
            print("Tuþlara basmadýnýz");
        }
        else
        {
            print("S veya aþaðý ok tuþu");
        }
    }
}
