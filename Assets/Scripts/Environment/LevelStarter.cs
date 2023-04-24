using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
        
    }

    // Update is called once per frame
   IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        PlayerMove.canMove = true;
    }
}
