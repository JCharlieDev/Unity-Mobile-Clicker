using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject autoCookie;
    public GameObject autoSell;
    public AudioSource playSound;

    public void StartAutoCookie()
    {
        playSound.Play();

        autoCookie.SetActive(true);

        GlobalCash.cashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.isTurnedOff = true;

        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;
    }

    public void StartAutoSell()
    {
        playSound.Play();

        autoSell.SetActive(true);

        GlobalCash.cashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *= 2;
        GlobalShop.isTurnedOff = true;

        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
}
