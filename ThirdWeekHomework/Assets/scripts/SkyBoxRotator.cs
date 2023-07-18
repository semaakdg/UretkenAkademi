using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotator : MonoBehaviour
{
    public int hiz = 1;

    private void FixedUpdate()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * hiz);
    }
}
