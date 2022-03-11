using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton1SEManager : MonoBehaviour
{
    private AudioSource audioSourceSE;
    public AudioClip releaseButton;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSourceSE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayReleaseButton()
    {
        audioSourceSE.PlayOneShot(releaseButton);
        Destroy(gameObject, 1.0f);
    }
}
