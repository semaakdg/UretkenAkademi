using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fonksiyonlar : MonoBehaviour
{
    
    void Start()
    {
        /*
        benimFonksiyonum(2, 3);
        benimFonksiyonum(7, 6);
        selamlama();
        selamla("Ayla", true);
        selamla("Ahmet", false);
        */
        int toplam1 = Topla(22, 33);//55 
        string selamMesaji = selamla("Ayla"); // Merhaba Ayla
        int toplam2 = Topla(44, toplam1); // 99
        print(selamMesaji + "Toplam sonucu : " + toplam2);
        // Merhaba Ayla toplam sonucu : 99
    }

    int Topla(int sayi1, int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        return sonuc;
    }
    int Cikar(int sayi1, int sayi2) 
    {
        return sayi1 - sayi2;
    }
    string selamla(string isim) 
    {
        return "Merhaba " + isim + " ";
    }


    void Update()
    {
        
    }

    void benimFonksiyonum(int a, int b)
    {
        /*
        print("Yaz� 1");
        print("G�rev 1");
        for (int i = 0; i < 10; i++) 
        {
            print(i + "sat�n�n 4 kat� : " + (4 * i));
        }*/
        print(a + " ve " + b + "say�lar�n�n birbiri ile �arp�m� :" + (a + b));
    }
    void selamlama() 
    {
        print("Merhaba");
    }
    void selamla(string isim, bool cinsiyet)
    {
        if(cinsiyet) 
        {
            print("Merhaba Han�mefendi " + isim);
        }
        else
        {
            print("Merhaba Beyefendi " + isim);
        }
    }

}
