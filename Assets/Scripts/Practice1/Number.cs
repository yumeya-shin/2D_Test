using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Number : MonoBehaviour
{
    //public Transform number;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    //public float positionX;
    public GameObject numberStarFXGenerator1, resultParent, resultStarFXGenerator1;
    public Transform result;
    public RectTransform rectTransform;
    public bool isDeltaPassed = false;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        numberStarFXGenerator1 = GameObject.Find("NumberStarFXGenerator1");
        resultParent = GameObject.Find("Canvas3");
        result = resultParent.transform.Find("Result");
        resultStarFXGenerator1 = GameObject.Find("ResultStarFXGenerator1");
        rectTransform = GetComponent<RectTransform>();
        //if (timeNow == DateTime.MaxValue)
        //{
        //    rectTransform.localPosition = new Vector3(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f, 0.0f);
        //    timeNow = DateTime.Now;
        //}
        if(isDeltaPassed == true)
        {
            Debug.Log(rectTransform.anchoredPosition.x);
            rectTransform.anchoredPosition = new Vector2(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 360.0f);
            Debug.Log(rectTransform.anchoredPosition.x);
            Debug.Log(timeDelta.TotalSeconds);
            isDeltaPassed = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if(timeNow == DateTime.MaxValue)
        //{
        //    rectTransform.localPosition = new Vector3(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f, 0.0f);
        //    timeNow = DateTime.Now;
        //}
        if(timeDelta > TimeSpan.FromSeconds(0.000))
        {
            if (isDeltaPassed == true)
            {
                Debug.Log(rectTransform.anchoredPosition.x);
                rectTransform.anchoredPosition = new Vector2(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 360.0f);
                Debug.Log(rectTransform.anchoredPosition.x);
                Debug.Log(timeDelta.TotalSeconds);
                isDeltaPassed = false;
            }
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            timeStart = timeNow;
            //positionX = -590.0f + ((float)timeDelta.TotalSeconds * 1080.0f / 3.500f);
            rectTransform.anchoredPosition += new Vector2((float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f);
            if (Input.GetMouseButtonUp(0) == true)
            {
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().isNumberStarFX = true;
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().numberStarFXPosition = GetComponent<RectTransform>().localPosition;
                if ((rectTransform.anchoredPosition.x >= 1093.0f) && (rectTransform.anchoredPosition.x < 1167.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 0;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 6;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.anchoredPosition.x >= 1065.0f) && (rectTransform.anchoredPosition.x < 1195.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 1;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 5;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.anchoredPosition.x >= 1038.0f) && (rectTransform.anchoredPosition.x < 1222.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 2;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 4;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.anchoredPosition.x >= 1005.0f) && (rectTransform.anchoredPosition.x < 1255.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 3;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 3;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.anchoredPosition.x >= 980.0f) && (rectTransform.anchoredPosition.x < 1280.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 4;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 2;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.anchoredPosition.x >= 955.0f) && (rectTransform.anchoredPosition.x < 1305.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 5;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 1;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if((rectTransform.anchoredPosition.x >= 930.0f) && (rectTransform.anchoredPosition.x < 1330.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 6;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 0;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else
                {
                    result.gameObject.GetComponent<Result>().result = 7;
                    result.gameObject.SetActive(true);
                }
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
            if (rectTransform.anchoredPosition.x >= 1330)
            {
                result.gameObject.GetComponent<Result>().result = 7;
                result.gameObject.SetActive(true);
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
        }
    }

    public void ResetSetting()
    {
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        //rectTransform.localPosition = new Vector3(50.0f, 0.0f, 0.0f);
    }
}
