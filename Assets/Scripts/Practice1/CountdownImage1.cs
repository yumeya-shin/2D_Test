using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class CountdownImage1 : MonoBehaviour
{
    public GameObject bgmTimeManager;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    public bool isCountdown;
    public Image spriteRenderer;
    public Sprite[] countdown = new Sprite[25];
    public int countdownSprite, countdownNumber;
    [SerializeField] static TimeSpan timeSum = TimeSpan.FromSeconds(0.500);

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        isCountdown = false;
        spriteRenderer = gameObject.GetComponent<Image>();
        countdownSprite = 0; countdownNumber = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(isCountdown == true)
        {
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            if(timeDelta > TimeSpan.FromSeconds(0.000))
            {
                if(timeDelta < timeSum)
                {
                    countdownSprite = (int)(timeDelta.TotalSeconds * 50);
                    spriteRenderer.sprite = countdown[countdownSprite];
                }
                else if(timeDelta >= timeSum)
                {
                    timeStart = timeNow;
                    timeDelta -= timeSum;
                    countdownNumber--;
                    if(countdownNumber == 0)
                    {
                        isCountdown = false;
                        gameObject.SetActive(false);
                    }
                }
            }
        }
    }

    public void ResetSetting()
    {
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        isCountdown = false;
        countdownSprite = 0; countdownNumber = 3;
    }
}
