using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownImage2_1 : MonoBehaviour
{
    public Image image;
    [SerializeField] public Sprite[] countdownSprite = new Sprite[25];
    public int countdownSpriteNumber, countdownNumber;
    public GameObject BGMTimeManager2;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public bool isCountdown = false;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        countdownSpriteNumber = 0; countdownNumber = 3;
        BGMTimeManager2 = GameObject.Find("BGMTimeManager2");
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        timeSum = TimeSpan.FromSeconds(60.0 / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM);
        if(isCountdown == true)
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
            //Debug.Log($"timeStart = {timeStart}");
            if (timeDelta > TimeSpan.FromSeconds(0.000))
            {
                if (timeDelta < timeSum)
                {
                    countdownSpriteNumber = (int)(timeDelta.TotalSeconds * 50 * BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM / 120);
                    image.sprite = countdownSprite[countdownSpriteNumber];
                }
                else if (timeDelta >= timeSum)
                {
                    timeStart = timeNow;
                    timeDelta -= timeSum;
                    countdownNumber--;
                    if (countdownNumber == 0)
                    {
                        //isCountdown = false;
                        gameObject.SetActive(false);
                    }
                }
            }
        }
        
    }
}
