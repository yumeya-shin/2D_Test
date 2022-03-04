using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonSEManager : MonoBehaviour
{
    private AudioSource audioSourceSE;
    public AudioClip releaseButton;

    public static StartButtonSEManager Instance
    {
        get; private set;
    }

    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSourceSE = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayReleaseButton()
    {
        audioSourceSE.PlayOneShot(releaseButton);
        Destroy(this.gameObject, 1.0f);
    }
}
