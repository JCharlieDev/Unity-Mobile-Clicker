using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GlobalCash : MonoBehaviour
{
    public static int cashCount;
    public int internalCash;

    public GameObject cashDisplay;

    void Update()
    {
        internalCash = cashCount;

        cashDisplay.GetComponent<TextMeshProUGUI>().text = $"$: {internalCash}";
    }
}
