using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
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
        }

    }
}
