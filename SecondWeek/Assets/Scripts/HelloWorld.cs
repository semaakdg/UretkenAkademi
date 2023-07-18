using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    /*
    public int can;
    [SerializeField] int ilave_can;
    int son_can;
    public bool oyunBittiMi = false;
    // Start is called before the first frame update
    void Start()
    {
        //print("start çalýþtý");
        can = 10;
        ilave_can = -11;
        son_can = can + ilave_can;
        if (son_can <= 0)
        {
            print("oyun bitti");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        print(son_can);
        print(oyunBittiMi);
        
    }*/


    //While kullanýmý
    public int sayi1;
    // Start is called before the first frame update
    void Start()
    {
        sayi1 = 10;
        while(sayi1 > 0)
        {
            print("Sayý : " +  sayi1);
            sayi1--;
        }
        print("Sayýnýn son hali : " + sayi1);

        //For kullanýmý
        for (int i = 10; i > 0; i--)
        {
            print("i deðeri : " + i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

   

}
