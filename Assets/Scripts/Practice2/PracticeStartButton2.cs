using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PracticeStartButton2 : MonoBehaviour
{
    public Image image;
    [SerializeField] public Sprite[] startButton = new Sprite[3];
    public bool BGMChange;
    [SerializeField] public AudioClip onButton, releaseButton;
    [SerializeField] public GameObject explanationTextTMP2, waitCountdownTextTMP2;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = startButton[0];
        BGMChange = false;
        explanationTextTMP2 = GameObject.Find("ExplanationTextTMP2");
        waitCountdownTextTMP2 = GameObject.Find("WaitCountdownTextTMP2");
        waitCountdownTextTMP2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if(BGMChange == true)
        {
            image.sprite = startButton[2];
        }
        else if(BGMChange == false)
        {
            image.sprite = startButton[1];
            AudioSource.PlayClipAtPoint(onButton, new Vector3(0.0f, 0.0f, -10.0f));
        }
    }

    void OnMouseOver()
    {
        if(BGMChange == true)
        {
            image.sprite = startButton[2];
        }
        else if((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            image.sprite = startButton[2];
            if(Input.GetMouseButtonUp(0) == true)
            {
                AudioSource.PlayClipAtPoint(releaseButton, new Vector3(0.0f, 0.0f, -10.0f));
                explanationTextTMP2.SetActive(false);
                waitCountdownTextTMP2.SetActive(true);
                BGMChange = true;
            }
        }
        else
        {
            image.sprite = startButton[1];
        }
    }

    void OnMouseExit()
    {
        if(BGMChange == true)
        {
            image.sprite = startButton[2];
        }
        else if(BGMChange == false)
        {
            image.sprite = startButton[0];
        }
    }
}
