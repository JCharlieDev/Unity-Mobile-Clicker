using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellCookie : MonoBehaviour
{
    [SerializeField] GameObject statusText;
    [SerializeField] AudioSource cash1;
    [SerializeField] AudioSource cash2;
    [SerializeField] AudioSource noCookie;

    public int generateTone;

    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 3);

        if (GlobalCookies.cookieCount != 0)
        {
            GlobalCookies.cookieCount -= 1;
            GlobalCash.cashCount += 1;

            if (generateTone == 1)
            {
                cash1.Play();
            }
            if (generateTone == 2)
            {
                cash2.Play();
            }
        }
        else
        {
            noCookie.Play();

            GlobalCookies.cookieCount = 0;
            statusText.GetComponent<TextMeshProUGUI>().text = "No cookies to sell :(";
            statusText.GetComponent<Animation>().Play("StatusAnim");
        }

    }
}
