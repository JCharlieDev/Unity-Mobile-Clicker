using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject shopStats;

    public static int shopValue = 1;
    public static int numberOfShops;
    public static int shopPerSec;

    public static bool isTurnedOff = false;

    public int currentCash;
    

    private void Update()
    {
        currentCash = GlobalCash.cashCount;

        fakeText.GetComponent<TextMeshProUGUI>().text = $"Buy Shop: {shopValue}$";
        realText.GetComponent<TextMeshProUGUI>().text = $"Buy Shop: {shopValue}$";

        shopStats.GetComponent<TextMeshProUGUI>().text = $"Shops: {numberOfShops} at {shopPerSec}$ per second";


        if (currentCash >= shopValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (isTurnedOff == true)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);

            isTurnedOff = false;
        }
    }
}
