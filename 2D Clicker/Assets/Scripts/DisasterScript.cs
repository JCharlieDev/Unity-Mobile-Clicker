using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public int cookieLoss;
    public int genChance;
    public float cookieCheck;
    public bool isDisasterActive = false;

    private void Update()
    {
        cookieCheck = GlobalCookies.cookieCount / 10;

        if (isDisasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        isDisasterActive = true;

        genChance = Random.Range(1, 20);

        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookies.cookieCount * .25f);

            statusBox.GetComponent<TextMeshProUGUI>().text = $"You lost {cookieLoss} cookies in a factory fire :(";
            GlobalCookies.cookieCount -= cookieLoss;
            yield return new WaitForSeconds(1);
            statusBox.GetComponent<Animation>().Play("StatusAnim");

        }
        yield return new WaitForSeconds(10);
        isDisasterActive = false;
    }
}
