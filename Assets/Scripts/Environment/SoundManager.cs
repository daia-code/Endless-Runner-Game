using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip backgroundMusic;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = backgroundMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        // Add sound effects or background music logic here
    }
}
