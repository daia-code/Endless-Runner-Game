using TMPro;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public TextMeshProUGUI coinCountDisplay;
    private int scoreValue = 1; // The value to add to the player's score when they collect this coin
    public int coinCount;

    public int ScoreValue { get => scoreValue; set => scoreValue = value; }

   public void Start()
    {
        coinCountDisplay = GameObject.Find("CoinCountDisplay").GetComponent<TextMeshProUGUI>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Call the AddScore function on the player controller script attached to the player GameObject
            other.GetComponent<PlayerMove>().AddScore(ScoreValue); 
            gameObject.SetActive(false); // Deactivate the coin GameObject
            ScoreValue = other.GetComponent<PlayerMove>().Score;
            
          

        }
        coinCountDisplay.text = ScoreValue.ToString();
    }
}

