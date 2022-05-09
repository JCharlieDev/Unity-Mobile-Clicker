using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject realButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject bakerStats;

    public static int bakerValue = 1;
    public static int numberOfBakers;
    public static int bakePerSec;

    public static bool isTurnedOff = false;

    public int currentCash;
    

    private void Update()
    {
        currentCash = GlobalCash.cashCount;

        fakeText.GetComponent<TextMeshProUGUI>().text = $"Buy Baker: {bakerValue}$";
        realText.GetComponent<TextMeshProUGUI>().text = $"Buy Baker: {bakerValue}$";

        bakerStats.GetComponent<TextMeshProUGUI>().text = $"Bakers: {numberOfBakers} at {bakePerSec}$ per second";


        if (currentCash >= bakerValue)
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
