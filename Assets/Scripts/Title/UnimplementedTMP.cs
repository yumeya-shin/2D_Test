using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UnimplementedTMP : MonoBehaviour
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
        if (isSetActive == true)
        {
            if (isTimeStart == false)
            {
                timeStart = DateTime.Now;
                isTimeStart = true;
            }
            else if(isTimeStart == true)
            {
                timeNow = DateTime.Now;
                timeDelta = (timeNow - timeStart);
                if (timeDelta.TotalSeconds > timeDraw.TotalSeconds)
                {
                    gameObject.SetActive(false);
                    isSetActive = false;
                    isTimeStart = false;
                }
            }
        }
    }
}
