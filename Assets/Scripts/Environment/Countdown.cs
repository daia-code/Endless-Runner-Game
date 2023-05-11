using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Countdown : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public GameObject menu;

    public Button startButton; // referință la butonul "Start" din interfața utilizatorului
    public Button retryButton; // referință la butonul "Retry" din interfața utilizatorului
    public Button name; // referință la butonul nume joc din interfața utilizatorului
    void Start()
    {
        Time.timeScale = 0f; // oprește jocul
        menu.SetActive(true); // afișează meniul
        // Adaugă o funcție care să fie apelată atunci când se face clic pe butonul "Start"
        startButton.onClick.AddListener(StartGame);

    }

    void StartGame()
    {
        HideMenu(); // ascunde meniul
        Time.timeScale = 1f; // reia jocul
     
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

        // Încarcă scena următoare după countdown
    }

    public void ShowMenu()
    {
        Time.timeScale = 0f; // oprește jocul
        menu.SetActive(true); // afișează meniul
     
 
    }

    public void HideMenu()
    {
        startButton.gameObject.SetActive(false);
        menu.gameObject.SetActive(false);
        StartCoroutine(CountdownCoroutine()); // pornește countdown-ul după ce meniul este ascuns
    }
}
