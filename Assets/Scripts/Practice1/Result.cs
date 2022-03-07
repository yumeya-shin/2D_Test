using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Result : MonoBehaviour
{
    public int result = -1;
    public Image spriteRenderer;
    public Sprite[] resultSprite = new Sprite[8];
    public DateTime timeStart, timeNow;
    public TimeSpan timeSum;
    const double timeWait = 1.000;
    public Transform retryButton1;
    public GameObject canvas3;

    // Start is called before the first frame update
    void Start()
    {
        if ((result >= 0) && (result <= 7))
        {
            spriteRenderer.sprite = resultSprite[result];
        }
        timeStart = DateTime.Now;
        canvas3 = GameObject.Find("Canvas3");
        retryButton1 = canvas3.transform.Find("RetryButton1");
    }

    // Update is called once per frame
    void Update()
    {
        if(timeStart == DateTime.MinValue)
        {
            timeStart = DateTime.Now;
        }
        if ((result >= 0) && (result <= 7))
        {
            spriteRenderer.sprite = resultSprite[result];
        }
        timeNow = DateTime.Now;
        timeSum = timeNow - timeStart;
        if(timeSum.TotalSeconds > 0.000)
        {
            if(timeSum.TotalSeconds >= timeWait)
            {
                retryButton1.gameObject.SetActive(true);
            }
        }
    }

    public void ResetSetting()
    {
        result = -1;
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
    }
}
