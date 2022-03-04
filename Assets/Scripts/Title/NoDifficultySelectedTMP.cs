using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoDifficultySelectedTMP : MonoBehaviour
{
    public bool isSetActive, isTimeStart;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    [SerializeField] static TimeSpan timeDraw = TimeSpan.FromSeconds(3.000);

    // Start is called before the first frame update
    void Start()
    {
        isSetActive = true;
        isTimeStart = false;
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MinValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
    }

    // Update is called once per frame
    void Update()
    {
        if(isSetActive == true)
        {
            //if(timeSum.Seconds == -0.001)
            //{
            //    timeStart = DateTime.Now;
            //    timeSum = TimeSpan.FromSeconds(0.000);
            //}
            /*else*/
            if(isTimeStart == false)
            {
                timeStart = DateTime.Now;
                isTimeStart = true;
                //Debug.Log($"isTimeStart = {isTimeStart}");
            }
            else if (isTimeStart == true)//if((DateTime.Now.Second - timeStart.Second) > TimeSpan.FromSeconds(3.000))
            {
                timeNow = DateTime.Now;
                timeDelta = (timeNow - timeStart);
                if (timeDelta.TotalSeconds > timeDraw.TotalSeconds)
                {
                    gameObject.SetActive(false);
                    isSetActive = false;
                    isTimeStart = false;
                }
                //Debug.Log($"timeDelta.TotalSeconds = {timeDelta.TotalSeconds}");
            }
        }
    }
}
