using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;
using TMPro;

public class New : MonoBehaviour
{
    public Slider sl;
    public TMP_Text TMmetin;
    public Text text;

    private void Start()
    {
        TMmetin.text = "Merhaba Dünya";

    }

    private void Update()
    {
        print(sl.value);
        print(text.text);
    }


}
