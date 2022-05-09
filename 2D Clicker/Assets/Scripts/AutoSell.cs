using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public static int cashIncrease = 1;

    public int internalIncrease;

    public bool isSellingCookie = false;

    private void Update()
    {
        cashIncrease = GlobalShop.shopPerSec;
        internalIncrease = cashIncrease;

        if (isSellingCookie == false)
        {
            isSellingCookie = true;

            StartCoroutine(CreateAutoSell());
        }
    }

    IEnumerator CreateAutoSell()
    {
        if (GlobalCookies.cookieCount == 0)
        {
            // ...
        }
        else
        {
            GlobalCash.cashCount += internalIncrease;
            GlobalCookies.cookieCount -= 1;

            yield return new WaitForSeconds(1);

            isSellingCookie = false;
        }

        
    }
}
