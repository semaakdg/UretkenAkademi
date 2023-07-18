using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    // Start is called before the first frame update
    public int sayi;

    void Start()
    {
        sayi = 7;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        int sonuc = sayi % 5;
        switch (sonuc) 
        {
            case 0:
                print("sayinin 5 e bölümünden kalan 0");
                break;
            case 1:
                print("sayinin 5 e bölümünden kalan 1");
                break;
            case 2:
                print("sayinin 5 e bölümünden kalan 2");
                break;
            case 3:
                print("sayinin 5 e bölümünden kalan 3");
                break;
            case 4:
                print("sayinin 5 e bölümünden kalan 4");
                break;
            case 5:
                print("sayinin 5 e bölümünden kalan 5");
                break;
        }*/
        int sonuc = sayi % 5;
        switch (sonuc)
        {
            case 0:
                print("sayinin 5 e bölümünden kalan 0");
                break;
            case 1:
                print("sayinin 5 e bölümünden kalan 1");
                break;
            case 2:
                print("sayinin 5 e bölümünden kalan 2");
                break;
            default:
                print("default durum");
                break;
        }

    }
}
