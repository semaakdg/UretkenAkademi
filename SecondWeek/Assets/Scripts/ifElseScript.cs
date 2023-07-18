using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifElseScript : MonoBehaviour
{
    public int can;
    // Start is called before the first frame update
    void Start()
    {
        can = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //DURUM 1
        if (can > 3) 
        {
            print("Oyun devam ediyor");
        }
        else if(can == 3)
        {
            print("3 cana özel 2 puan");
        }
        else if(can > 0)
        {
            print("0-3 rasý özel durum");
        }
        else
        {
            print("Oyýn bitti");
        }

        //DURUM 2
        if (can ==5 )
        {
            print("_________ 5 e özel bir durum var.");
        }
        else 
        {
            print("________ özel bir durum yok.");
        }
    }
}
