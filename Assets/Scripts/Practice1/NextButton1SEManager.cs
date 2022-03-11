using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton1SEManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayReleaseButton()
    {
        Destroy(gameObject, 1.0f);
    }
}
