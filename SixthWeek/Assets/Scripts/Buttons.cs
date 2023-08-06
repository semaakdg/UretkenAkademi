using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject panel;
    public void CikisButonu()
    {
        print("Oyundan çýkýldý");
        Application.Quit();

    }

    public void NewGame()
    {
        SceneManager.LoadScene(1); // new game butonuna bastýðýmda gideceði sahnnenin build settingsteki yeri
        //SceneManager.LoadScene("NewGame");
    }

    public void FirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void On_Value_Changed(float Deger)
    {
        print(Deger);
    }

    public void ToggleEnabled(bool TiklandiMi)
    {
        if(TiklandiMi) 
        {
            print("Ses aktif");
        }
        else 
        {
            print("Ses kapatýldý");
        }
    }

    public void OnEndEditText(string metinselDeger)
    {
        print("metin: " +  metinselDeger);
    }

    public void DropdownValue(int sayi)
    {
        if (sayi == 0) 
        {
            print("Araba alýmý");
        }
        else if (sayi == 1)
        {
            print("Ev alýmý");
        }
        else if (sayi == 2)
        {
            print("Arsa alýmý");
        }
    }

    public void GeriDon()
    {
        panel.gameObject.SetActive(true);
    }

}
