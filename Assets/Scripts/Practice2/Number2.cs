using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Number2 : MonoBehaviour
{
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    public bool isTimePass = false;
    public RectTransform rectTransform;
    [SerializeField] public GameObject canvas, BGMTimeManager2;
    [SerializeField] public RectTransform canvasRectTransform;
    public float canvasWidth, canvasHeight;
    [SerializeField] public Image image;
    [SerializeField] public Sprite[] sprite = new Sprite[11];
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.MinValue; timeNow = DateTime.MaxValue;
        rectTransform = gameObject.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas3");
        canvasRectTransform = canvas.GetComponent<RectTransform>();
        canvasWidth = canvasRectTransform.sizeDelta.x; canvasHeight = canvasRectTransform.sizeDelta.y;
        Debug.Log($"canvasWidth = {canvasWidth}");
        Debug.Log($"canvasHeight = {canvasHeight}");
        BGMTimeManager2 = GameObject.Find("BGMTimeManager2");
        if (isTimePass == true)
        {
            timeStart = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeStart;
            timeDelta = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeDelta;
            rectTransform.anchoredPosition = new Vector2(50.0f + (float)timeDelta.TotalSeconds * (canvasWidth - 50.0f - 150.0f) / (60.0f / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM * 7.0f), canvasHeight / 2.0f);
            isTimePass = false;
        }
        number = UnityEngine.Random.Range(0, 10);
        image.sprite = sprite[number];
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimePass == true)
        {
            timeStart = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeStart;
            timeDelta = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeDelta;
            rectTransform.anchoredPosition = new Vector2(50.0f + (float)timeDelta.TotalSeconds * (canvasWidth - 50.0f - 150.0f) / (60.0f / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM * 7.0f), canvasHeight / 2.0f);
            isTimePass = false;
        }
        else if((isTimePass == false) && (timeStart != DateTime.MinValue))
        {
            if(timeDelta == TimeSpan.FromSeconds(0.000))
            {
                timeDelta = TimeSpan.FromSeconds(0.001);
            }
            if (timeDelta > TimeSpan.FromSeconds(0.000))
            {
                timeNow = DateTime.Now;
                timeDelta = timeNow - timeStart;
                timeStart = timeNow;
                //Debug.Log($"timeDelta = {timeDelta}");
                rectTransform.anchoredPosition += new Vector2((float)timeDelta.TotalSeconds * (canvasWidth - 50.0f - 150.0f) / (60.0f / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM * 7.0f), 0.0f);
            }
        }
    }
}
