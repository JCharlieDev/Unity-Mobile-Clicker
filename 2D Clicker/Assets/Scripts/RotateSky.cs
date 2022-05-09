using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float rotationSpeed = 4.0f;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotationSpeed * Time.time);
    }
}
