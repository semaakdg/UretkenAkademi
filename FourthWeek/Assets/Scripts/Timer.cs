using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float timer;

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime = 1/fbs  -- Mesela fbs = 120 ise 1/120 yani 120 i�lem gibi d���nebiliriz.. 60 ise 60 gibi gibi
    }
    private void FixedUpdate() // fbsimiz ne olursa olsun saniyede 60 i�lem yap�yor
    {
        //burada mesela belli bir �arpanla i�lemi h�zland�rabiliriz, 1.5f e ��kartabiliriz
        timer += 5 * Time.deltaTime;
        print(timer);
    }
}
