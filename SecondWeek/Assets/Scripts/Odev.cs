using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odev : MonoBehaviour
{
    public void bolenleriBul(int ilkSayi, int ikinciSayi)
    {
        string listString = "T�m� :";
        string listString2 = "Ikiye B�l�nenler :";
        string listString3 = "��e B�l�nenler :";
        string listString4 = "D�rde B�l�nenler :";
        string listString5 = "Be�e B�l�nenler :";

        for (int i = ilkSayi; i <= ikinciSayi; i++)
        {
            listString += " " + i;
            if (i % 2 == 0)
            {
                listString2 += " " + i;
            }
            if (i % 3 == 0)
            {
                listString3 += " " + i;
            }
            if (i % 4 == 0)
            {
                listString4 += " " + i;
            }
            if (i % 5 == 0)
            {
                listString5 += " " + i;
            }

        }

        print(listString);
        print(listString2);
        print(listString3);
        print(listString4);
        print(listString5);


    }
    void Start()
    {
        bolenleriBul(2, 23);

    }
}
