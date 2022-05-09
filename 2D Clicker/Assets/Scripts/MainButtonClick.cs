using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource cookieSound;

    public void ClickTheButton()
    {
        cookieSound.Play();

        GlobalCookies.cookieCount += 1;
    }

}
