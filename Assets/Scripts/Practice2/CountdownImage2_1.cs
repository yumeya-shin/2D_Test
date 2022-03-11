using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownImage2_1 : MonoBehaviour
{
    public Image image;
    [SerializeField] public Sprite[] countdown = new Sprite[25];
    public GameObject BGMTimeManager2;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public bool isCountdown;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        BGMTimeManager2 = GameObject.Find("BGMTimeManager2");
        timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;
        timeDelta = TimeSpan.FromSeconds(0.000);
        timeSum = TimeSpan.FromSeconds(60.0 / BGMTimeManager2.GetComponent<BGMTimeManager2>().gameBGMBPM * 1.0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
