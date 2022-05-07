using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCookies : MonoBehaviour
{
    public static int cookieCount;
    public int internalCookie;

    public GameObject cookieDisplay;


    void Update()
    {
        internalCookie = cookieCount;
        cookieDisplay.GetComponent<TextMeshProUGUI>().text = $"Cookies: {internalCookie}";
        
    }
}
