using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveGame : MonoBehaviour
{
    public GameObject saveButton;
    public GameObject saveText;

    public static int saveValue = 10;
    public int saveGameCash;



    private void Update()
    {
        saveText.GetComponent<TextMeshProUGUI>().text = $"Cost: {saveValue}$";
        saveGameCash = GlobalCash.cashCount;

        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent <Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalCash.cashCount -= saveValue;

        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.cookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.cashCount);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.bakePerSec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);

        saveValue *= 2;

        PlayerPrefs.SetInt("SaveValue", saveValue);

    }
}
