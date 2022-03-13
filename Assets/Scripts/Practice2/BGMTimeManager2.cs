using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BGMTimeManager2 : MonoBehaviour
{
    public bool isSceneChanged = false;
    public int switchBGM;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public AudioSource audioSource;
    public AudioClip gameBGM;
    public float gameBGMBPM = 120.0f;
    [SerializeField] public GameObject practiceStartButton2, canvas1, canvas2, canvas3, countdownImage2_1, countdownImage2_2, number2;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log($"isSceneChanged = {isSceneChanged}");
        //Debug.Log($"switchBGM = {switchBGM}");
        //Debug.Log($"timeStart = {timeStart}");
        //Debug.Log($"timeNow = {timeNow}");
        //Debug.Log($"timeDelta = {timeDelta}");
        //Debug.Log($"timeSum = {timeSum}");
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = gameBGM;
        timeSum = TimeSpan.FromSeconds(60.0f / gameBGMBPM * 4.0f);
        practiceStartButton2 = GameObject.Find("PracticeStartButton2");
        canvas1 = GameObject.Find("Canvas1"); canvas2 = GameObject.Find("Canvas2"); canvas3 = GameObject.Find("Canvas3");
        countdownImage2_1 = GameObject.Find("CountdownImage2_1"); countdownImage2_2 = GameObject.Find("CountdownImage2_2"); number2 = GameObject.Find("Number2");
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        if (isSceneChanged == true)
        {
            switch(switchBGM)
            {
                case 0:
                    audioSource.time = 60.0f / gameBGMBPM * 192.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 1:
                    audioSource.time = 60.0f / gameBGMBPM * 196.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 2:
                    audioSource.time = 60.0f / gameBGMBPM * 200.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 3:
                    audioSource.time = 60.0f / gameBGMBPM * 204.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 4:
                    audioSource.time = 60.0f / gameBGMBPM * 216.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 5:
                    audioSource.time = 60.0f / gameBGMBPM * 220.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 10:
                    audioSource.time = 60.0f / gameBGMBPM * 88.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                case 11:
                    audioSource.time = 60.0f / gameBGMBPM * 92.0f + (float)timeDelta.TotalSeconds;
                    audioSource.PlayDelayed(0.0f);
                    break;
                default:
                    break;
            }
        }
        else if(isSceneChanged == false)
        {
            audioSource.time = 60.0f / gameBGMBPM * 192.0f;
            switchBGM = 0;
            audioSource.PlayDelayed(0.0f);
            timeStart = DateTime.Now;
            timeNow = DateTime.Now;
            timeDelta = TimeSpan.FromSeconds(0.000);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = DateTime.Now;
        timeDelta = timeNow - timeStart;
        if(timeDelta > TimeSpan.FromSeconds(0.000))
        {
            if(timeDelta >= timeSum)
            {
                timeStart = timeNow;
                timeDelta -= timeSum;

                switch(switchBGM)
                {
                    case 0:
                        audioSource.Stop();
                        if(practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == true)
                        {
                            audioSource.time = (60.0f / gameBGMBPM * 220.0f + (float)timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange = false;
                            countdownImage2_1.GetComponent<CountdownImage2_1>().isCountdown = true;
                            countdownImage2_2.GetComponent<CountdownImage2_2>().isCountdown = true;
                            canvas1.SetActive(false);
                            canvas2.SetActive(true);
                            switchBGM = 5;
                        }
                        else if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == false)
                        {
                            audioSource.time = 60.0f / gameBGMBPM * 196.0f + (float)timeDelta.TotalSeconds;
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 1;
                        }
                        break;
                    case 1:
                        audioSource.Stop();
                        if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == true)
                        {
                            audioSource.time = (60.0f / gameBGMBPM * 216.0f + (float)timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 4;
                        }
                        else if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == false)
                        {
                            audioSource.time = 60.0f / gameBGMBPM * 200.0f + (float)timeDelta.TotalSeconds;
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 2;
                        }
                        break;
                    case 2:
                        audioSource.Stop();
                        if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == true)
                        {
                            audioSource.time = (60.0f / gameBGMBPM * 220.0f + (float)timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange = false;
                            countdownImage2_1.GetComponent<CountdownImage2_1>().isCountdown = true;
                            countdownImage2_2.GetComponent<CountdownImage2_2>().isCountdown = true;
                            canvas1.SetActive(false);
                            canvas2.SetActive(true);
                            switchBGM = 5;
                        }
                        else if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == false)
                        {
                            audioSource.time = 60.0f / gameBGMBPM * 204.0f + (float)timeDelta.TotalSeconds;
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 3;
                        }
                        break;
                    case 3:
                        audioSource.Stop();
                        if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == true)
                        {
                            audioSource.time = (60.0f / gameBGMBPM * 216.0f + (float)timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 4;
                        }
                        else if (practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange == false)
                        {
                            audioSource.time = 60.0f / gameBGMBPM * 192.0f + (float)timeDelta.TotalSeconds;
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 0;
                        }
                        break;
                    case 4:
                        audioSource.Stop();
                        audioSource.time = (60.0f / gameBGMBPM * 220.0f + (float)timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        practiceStartButton2.GetComponent<PracticeStartButton2>().BGMChange = false;
                        countdownImage2_1.GetComponent<CountdownImage2_1>().isCountdown = true;
                        countdownImage2_2.GetComponent<CountdownImage2_2>().isCountdown = true;
                        canvas1.SetActive(false);
                        canvas2.SetActive(true);
                        switchBGM = 5;
                        break;
                    case 5:
                        audioSource.Stop();
                        audioSource.time = (60.0f / gameBGMBPM * 88.0f + (float)timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        number2.GetComponent<Number2>().isTimePass = true;
                        canvas2.SetActive(false);
                        canvas3.SetActive(true);
                        switchBGM = 10;
                        break;
                    case 10:
                        audioSource.Stop();
                        audioSource.time = 60.0f / gameBGMBPM * 92.0f + (float)timeDelta.TotalSeconds;
                        audioSource.PlayDelayed(0.0f);
                        switchBGM = 11;
                        break;
                    case 11:
                        audioSource.Stop();
                        audioSource.time = 60.0f / gameBGMBPM * 192.0f + (float)timeDelta.TotalSeconds;
                        audioSource.PlayDelayed(0.0f);
                        switchBGM = 0;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
