using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryButton1 : MonoBehaviour
{
    public Image image;
    public AudioClip onButton, releaseButton;
    public Sprite[] retryButton = new Sprite[3];
    [SerializeField] public GameObject canvas1Parent;
    [SerializeField] public Transform canvas1, explanationTextTMP, waitCountdownTextTMP, practiceStartButton1, canvas2, countdownImage1, countdownImage2, canvas3, number, result, resultStarFXGenerator1;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        canvas1Parent = GameObject.Find("Explanation1");
        canvas1 = canvas1Parent.transform.Find("Canvas1");
        waitCountdownTextTMP = canvas1Parent.transform.Find("Canvas1/WaitCountdownTextTMP");
        explanationTextTMP = canvas1Parent.transform.Find("Canvas1/ExplanationTextTMP");
        practiceStartButton1 = canvas1Parent.transform.Find("Canvas1/PracticeStartButton1");
        canvas2 = canvas1Parent.transform.Find("Canvas2");
        countdownImage1 = canvas1Parent.transform.Find("Canvas2/CountdownImage1");
        countdownImage2 = canvas1Parent.transform.Find("Canvas2/CountdownImage2");
        canvas3 = canvas1Parent.transform.Find("Canvas3");
        number = canvas1Parent.transform.Find("Canvas3/Number");
        result = canvas1Parent.transform.Find("Canvas3/Result");
        resultStarFXGenerator1 = canvas1Parent.transform.Find("Canvas3/ResultStarFXGenerator1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        image.sprite = retryButton[1];
        AudioSource.PlayClipAtPoint(onButton, new Vector3(0, 0, -10));
    }

    void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            image.sprite = retryButton[2];
            if (Input.GetMouseButtonUp(0) == true)
            {
                AudioSource.PlayClipAtPoint(releaseButton, new Vector3(0, 0, -10));
                canvas1.gameObject.SetActive(true);
                explanationTextTMP.gameObject.SetActive(true);
                waitCountdownTextTMP.gameObject.SetActive(false);
                practiceStartButton1.gameObject.GetComponent<PracticeStartButton1>().ResetSetting();
                canvas2.gameObject.SetActive(false);
                countdownImage1.gameObject.GetComponent<CountdownImage1>().ResetSetting();
                countdownImage2.gameObject.GetComponent<CountdownImage2>().ResetSetting();
                canvas3.gameObject.SetActive(false);
                number.gameObject.GetComponent<Number>().ResetSetting();
                result.gameObject.GetComponent<Result>().ResetSetting();
                resultStarFXGenerator1.gameObject.GetComponent<ResultStarFXGenerator1>().ResetSetting();
                image.sprite = retryButton[0];
            }
        }
        else
        {
            image.sprite = retryButton[1];
        }
    }

    void OnMouseExit()
    {
        image.sprite = retryButton[0];
    }
}
