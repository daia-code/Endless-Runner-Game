using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelDistance : MonoBehaviour
{
    public TextMeshProUGUI distanceCountDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;
    public GameObject gameObject;
    // Update is called once per frame
    void Update()
    {
        if (addingDis == false)
        {
           
                addingDis = true;

                StartCoroutine(AddingDis());
    
        }
    }
    IEnumerator AddingDis()
    {
        if (gameObject.GetComponent<PlayerMove>().finish == false)
        {
            disRun += 1;
            distanceCountDisplay.text = disRun.ToString();
            yield return new WaitForSeconds(disDelay);
            addingDis = false;
        }
        
    }
}
