using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultScript : MonoBehaviour
{
    public int result = -1;
    public bool isResult = false;
    [SerializeField] public Image image;
    [SerializeField] public Sprite[] sprite = new Sprite[9];
    public GameObject number, canvas;
    public RectTransform numberRectTransform;
    public Transform nextButton;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    const double timeWait = 1.000;

    // Start is called before the first frame update
    void Start()
    {
        number = GameObject.Find("Number");
        numberRectTransform = number.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas3");
        if(isResult == true)
        {
            if((numberRectTransform.anchoredPosition.x >= 1093.0f) && (numberRectTransform.anchoredPosition.x < 1167.0f))
            {
                result = 0;
            }
            else if((numberRectTransform.anchoredPosition.x >= 1065.0f) && (numberRectTransform.anchoredPosition.x < 1195.0f))
            {
                result = 1;
            }
            else if((numberRectTransform.anchoredPosition.x >= 1038.0f) && (numberRectTransform.anchoredPosition.x < 1222.0f))
            {
                result = 2;
            }
            else if((numberRectTransform.anchoredPosition.x >= 1005.0f) && (numberRectTransform.anchoredPosition.x < 1255.0f))
            {
                result = 3;
            }
            else if((numberRectTransform.anchoredPosition.x >= 980.0f) && (numberRectTransform.anchoredPosition.x < 1280.0f))
            {
                result = 4;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 955.0f) && (numberRectTransform.anchoredPosition.x < 1305.0f))
            {
                result = 5;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 930.0f) && (numberRectTransform.anchoredPosition.x < 1330.0f))
            {
                result = 6;
            }
            else
            {
                result = 7;
            }
            isResult = false;
        }
        if((result >= 0) && (result <= 7))
        {
            image.sprite = sprite[result];
        }
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
    }

    // Update is called once per frame
    void Update()
    {
        if (isResult == true)
        {
            if ((numberRectTransform.anchoredPosition.x >= 1093.0f) && (numberRectTransform.anchoredPosition.x < 1167.0f))
            {
                result = 0;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1065.0f) && (numberRectTransform.anchoredPosition.x < 1195.0f))
            {
                result = 1;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1038.0f) && (numberRectTransform.anchoredPosition.x < 1222.0f))
            {
                result = 2;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1005.0f) && (numberRectTransform.anchoredPosition.x < 1255.0f))
            {
                result = 3;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 980.0f) && (numberRectTransform.anchoredPosition.x < 1280.0f))
            {
                result = 4;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 955.0f) && (numberRectTransform.anchoredPosition.x < 1305.0f))
            {
                result = 5;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 930.0f) && (numberRectTransform.anchoredPosition.x < 1330.0f))
            {
                result = 6;
            }
            else
            {
                result = 7;
            }
            isResult = false;
        }
        if ((result >= 0) && (result <= 7))
        {
            image.sprite = sprite[result];
        }
        if (timeStart == DateTime.MinValue)
        {
            timeStart = DateTime.Now;
        }
        timeNow = DateTime.Now;
        timeDelta = timeNow - timeStart;
        if(timeDelta == TimeSpan.FromSeconds(0.000))
        {
            timeDelta = TimeSpan.FromSeconds(0.001);
        }
        if(timeDelta > TimeSpan.FromSeconds(0.000))
        {
            if(timeDelta.TotalSeconds >= timeWait)
            {

            }
        }
    }
}
