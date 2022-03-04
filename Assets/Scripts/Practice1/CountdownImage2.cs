using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CountdownImage2 : MonoBehaviour
{
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    public bool isCountdown;
    public Image spriteRenderer;
    public Sprite[] countdown = new Sprite[4];
    public int countdownNumber;
    public GameObject countdownImage1;
    [SerializeField] static TimeSpan timeSum = TimeSpan.FromSeconds(0.500);

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MinValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        isCountdown = false;
        spriteRenderer = gameObject.GetComponent<Image>();
        countdownNumber = 0;
        countdownImage1 = GameObject.Find("CountdownImage1");
    }

    // Update is called once per frame
    void Update()
    {
        if(isCountdown == true)
        {
            //timeDelta = countdownImage1.GetComponent<CountdownImage1>().timeDelta;
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            if (timeDelta > TimeSpan.FromSeconds(0.000))
            {
                if(timeDelta < timeSum)
                {
                    spriteRenderer.sprite = countdown[countdownNumber];
                }
                else if(timeDelta >= timeSum)
                {
                    timeStart = timeNow;
                    timeDelta -= timeSum;
                    countdownNumber++;
                    if(countdownNumber == 3)
                    {
                        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(798.0f, 350.0f);
                    } 
                    else if(countdownNumber == 4)
                    {
                        isCountdown = false;
                        gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
