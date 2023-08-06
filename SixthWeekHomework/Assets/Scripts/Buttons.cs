using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject panel;
    public void ExýtButton()
    {
        Application.Quit();

    }

    public void Second()
    {
        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Second");
    }

    public void First()
    {
        SceneManager.LoadScene(0);
    }


    public void OnEndEditText(string metinselDeger)
    {
        print("metin: " + metinselDeger);
    }

    public void DropdownValue(int sayi)
    {
        if (sayi == 0)
        {
            print("Yes, exactly");
        }
        else if (sayi == 1)
        {
            print("No, I don't");
        }
        else if (sayi == 2)
        {
            print("I'm not sure");
        }
    }

    public void GeriDon()
    {
        panel.gameObject.SetActive(true);
    }

}
