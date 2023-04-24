using System.Collections;
using TMPro;
using UnityEngine;

public class ObstacolesCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public float delayTime = 1.5f;

    public void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        Debug.Log("Obstacole collision");
        // Start the player movement again after a delay
        StartCoroutine(RestartPlayerMovement());
    }

    IEnumerator RestartPlayerMovement()
    {
        yield return new WaitForSeconds(delayTime);
        thePlayer.GetComponent<PlayerMove>().enabled = true;
        charModel.GetComponent<Animator>().Play("Standard Run");
    }
}


