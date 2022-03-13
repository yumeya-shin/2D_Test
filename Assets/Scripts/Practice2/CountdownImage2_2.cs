using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownImage2_2 : MonoBehaviour
{
    public Image image;
    [SerializeField] public Sprite[] numberSprite = new Sprite[4];
    public int countdownNumber;
    public GameObject BGMTimeManager2;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public bool isCountdown = false;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        countdownNumber = 0;
        BGMTimeManager2 = GameObject.Find("BGMTimeManager2");
        timeStart = DateTime.MinValue; timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000); timeSum = TimeSpan.FromSeconds(60.0 / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM);
        if (isCountdown == true)
        {
            timeStart = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeStart;
            timeDelta = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeDelta;
            isCountdown = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountdown == true)
        {
            timeStart = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeStart;
            timeDelta = BGMTimeManager2.GetComponent<BGMTimeManager2>().timeDelta;
            isCountdown = false;
        }
        else if((isCountdown == false) && (timeStart != DateTime.MinValue))
        {
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            if (timeDelta > TimeSpan.FromSeconds(0.000))
            {
                if (timeDelta < timeSum)
                {
                    image.sprite = numberSprite[countdownNumber];
                }
                else if (timeDelta >= timeSum)
                {
                    timeStart = timeNow;
                    timeDelta -= timeSum;
                    countdownNumber++;
                    if (countdownNumber == 3)
                    {
                        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(798.0f, 350.0f);
                    }
                    else if (countdownNumber == 4)
                    {
                        gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
