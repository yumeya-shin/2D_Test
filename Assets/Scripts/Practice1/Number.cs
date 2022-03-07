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
            Debug.Log(rectTransform.localPosition.x);
            //rectTransform.localPosition = new Vector3(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f, 0.0f);
            Debug.Log(rectTransform.localPosition.x);
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
                Debug.Log(rectTransform.localPosition.x);
                rectTransform.localPosition = new Vector3(50.0f + (float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f, 0.0f);
                Debug.Log(rectTransform.localPosition.x);
                Debug.Log(timeDelta.TotalSeconds);
                isDeltaPassed = false;
            }
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            timeStart = timeNow;
            //positionX = -590.0f + ((float)timeDelta.TotalSeconds * 1080.0f / 3.500f);
            rectTransform.localPosition += new Vector3((float)timeDelta.TotalSeconds * 1080.0f / 3.500f, 0.0f, 0.0f);
            if (Input.GetMouseButtonUp(0) == true)
            {
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().isNumberStarFX = true;
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().numberStarFXPosition = GetComponent<RectTransform>().localPosition;
                if ((rectTransform.localPosition.x >= 453.0f) && (rectTransform.localPosition.x < 527.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 0;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 6;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.localPosition.x >= 425.0f) && (rectTransform.localPosition.x < 555.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 1;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 5;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.localPosition.x >= 398.0f) && (rectTransform.localPosition.x < 582.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 2;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 4;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.localPosition.x >= 365.0f) && (rectTransform.localPosition.x < 615.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 3;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 3;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.localPosition.x >= 340.0f) && (rectTransform.localPosition.x < 640.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 4;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 2;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if ((rectTransform.localPosition.x >= 315.0f) && (rectTransform.localPosition.x < 665.0f))
                {
                    result.gameObject.GetComponent<Result>().result = 5;
                    result.gameObject.SetActive(true);
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().result = 1;
                    resultStarFXGenerator1.GetComponent<ResultStarFXGenerator1>().isResultStarFX = true;
                }
                else if((rectTransform.localPosition.x >= 290.0f) && (rectTransform.localPosition.x < 690.0f))
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
            if (rectTransform.localPosition.x >= 1330)
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
