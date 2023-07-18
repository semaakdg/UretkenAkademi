using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    float[] liste = { 2f, 2.5f, 11f, 11.5f };

    void Start()
    {
        /*
        liste[0] = 22.4f;
        string listeString = "";
        foreach(float eleman in liste)
        {
            listeString += " " + eleman;
        }
        print("tüm liste elemanlarý : " + listeString);
        */

        ArrayList benimListem = new ArrayList();
        benimListem.Add(22);
        benimListem.Add(34);
        benimListem.Add(500);

        foreach(int eleman in benimListem)
        {
            print(eleman);
        }

    }

    void Update()
    {
        
    }
}
