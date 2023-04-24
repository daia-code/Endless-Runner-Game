using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;

    void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    IEnumerator CountdownCoroutine()
    {
        countdownText.text = "3";
        yield return new WaitForSeconds(0.3f);

        countdownText.text = "2";
        yield return new WaitForSeconds(0.3f);

        countdownText.text = "1";
        yield return new WaitForSeconds(0.3f);

        countdownText.text = "Start!";
        yield return new WaitForSeconds(0.3f);

        countdownText.gameObject.SetActive(false);
    }
}

