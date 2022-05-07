using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellCookie : MonoBehaviour
{
    [SerializeField] GameObject statusText;

    public void ClickTheButton()
    {
        if (GlobalCookies.cookieCount != 0)
        {
            GlobalCookies.cookieCount -= 1;
            GlobalCash.cashCount += 1;            
        }
        else
        {
            GlobalCookies.cookieCount = 0;
            statusText.GetComponent<TextMeshProUGUI>().text = "No cookies to sell :(";
            statusText.GetComponent<Animation>().Play("StatusAnim");
        }

    }
}
