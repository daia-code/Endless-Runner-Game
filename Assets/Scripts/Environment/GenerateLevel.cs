using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos=20;
    public bool creatingSection = false;
    public int secNum;
    // Start is called before the first frame update
    void Start()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

  IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 1);
        Instantiate(section[secNum],new Vector3(0,0,zPos),Quaternion.identity);
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
