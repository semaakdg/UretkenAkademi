using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aritmetikİslemler : MonoBehaviour
{
    public int sayi1, sayi2, toplam, fark, kalan, carpım;
    public float bolum;

    // Start is called before the first frame update
    void Start()
    {
        sayi1 = 10;
        sayi2 = 20;
        
    }

    // Update is called once per frame
    void Update()
    {
        toplam = sayi1 + sayi2;
        fark = sayi2 - sayi1;
        kalan = sayi1 % sayi2;
        carpım = sayi1 * sayi2;
        bolum = (float)  sayi1 / sayi2;
        print(sayi1 + " ile " + sayi2 + "'nın toplamı :" + toplam);
        print(sayi1 + " ile " + sayi2 + "'nın farkı :" + fark);
        print(sayi1 + " ile " + sayi2 + "'nın çarpımı :" + carpım);
        print(sayi1 + " ile " + sayi2 + "'nın bölümü :" + bolum + " ve bölümünden kalan " + kalan);

    }
}
