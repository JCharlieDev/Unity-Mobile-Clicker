using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCookie : MonoBehaviour
{
    public static int cookieIncrease = 1;

    public int internalIncrease;

    public bool isCreatiingCookie = false;

    private void Update()
    {
        cookieIncrease = GlobalBaker.bakePerSec;
        internalIncrease = cookieIncrease;

        if (isCreatiingCookie == false)
        {
            isCreatiingCookie = true;

            StartCoroutine(CreateTheCookie());
        }
    }

    IEnumerator CreateTheCookie()
    {

        GlobalCookies.cookieCount += internalIncrease;

        yield return new WaitForSeconds(1.0f);

        isCreatiingCookie = false;
    }
}
