using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PracticeStartButton1 : MonoBehaviour
{
    //public SpriteRenderer mainSpriteRenderer;
    public Image mainSpriteRenderer;
    public AudioClip onButton, releaseButton;
    public Sprite[] startButton = new Sprite[3];
    public bool bgmChange;
    [SerializeField] public GameObject explanationTextTMP, waitCountdownTextTMP;

    // Start is called before the first frame update
    void Start()
    {
        mainSpriteRenderer = gameObject.GetComponent<Image>();
        explanationTextTMP = GameObject.Find("ExplanationTextTMP");
        waitCountdownTextTMP = GameObject.Find("WaitCountdownTextTMP");
        waitCountdownTextTMP.SetActive(false);
        mainSpriteRenderer.sprite = startButton[0];
        bgmChange = false;
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        mainSpriteRenderer.sprite = startButton[1];
        AudioSource.PlayClipAtPoint(onButton, new Vector3(0, 0, -10));
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }

    void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            mainSpriteRenderer.sprite = startButton[2];
            //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
            if (Input.GetMouseButtonUp(0) == true)
            {
                explanationTextTMP.SetActive(false);
                waitCountdownTextTMP.SetActive(true);
                bgmChange = true;
            }
        }
        else
        {
            mainSpriteRenderer.sprite = startButton[1];
            //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
        }
    }

    void OnMouseExit()
    {
        if(bgmChange == true)
        {
            mainSpriteRenderer.sprite = startButton[1];
        }
        else if(bgmChange == false)
        {
            mainSpriteRenderer.sprite = startButton[0];
        }
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }
}