using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BGMManager : MonoBehaviour
{
    public AudioSource audioSource;
    //public AudioClip[] gameBGM = new AudioClip[12];
    public AudioClip gameBGM;
    public int switchBGM;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    [SerializeField] static TimeSpan timeSum = TimeSpan.FromSeconds(2.000);
    public GameObject practiceStartButton1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //audioSource.clip = gameBGM[0];
        audioSource.clip = gameBGM;
        audioSource.time = 96.0f;
        switchBGM = 0;
        audioSource.PlayDelayed(0.0f);
        //audioSource.PlayDelayed(96.0f);
        timeStart = DateTime.Now;
        timeNow = DateTime.Now;
        timeDelta = TimeSpan.FromSeconds(0.000);
        practiceStartButton1 = GameObject.Find("PracticeStartButton1");
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
                switch (switchBGM)
                {
                    case 0:
                        audioSource.Stop();
                        if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == true)
                        {
                            audioSource.time = (float)(110.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 5;
                        }
                        else if(practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == false)
                        {
                            //audioSource.clip = gameBGM[1];
                            //audioSource.PlayDelayed((float)timeDelta.TotalSeconds);
                            audioSource.time = (float)(98.0f + timeDelta.TotalSeconds);
                            //audioSource.PlayDelayed((float)(98.0f + timeDelta.TotalSeconds));
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 1;
                        }
                        break;
                    case 1:
                        audioSource.Stop();
                        if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == true)
                        {
                            audioSource.time = (float)(108.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 4;
                        }
                        else if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == false)
                        {
                            //audioSource.clip = gameBGM[2];
                            //audioSource.PlayDelayed((float)timeDelta.TotalSeconds);
                            //audioSource.PlayDelayed((float)(100.0f + timeDelta.TotalSeconds));
                            audioSource.time = (float)(100.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 2;
                        }
                        break;
                    case 2:
                        audioSource.Stop();
                        if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == true)
                        {
                            audioSource.time = (float)(110.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 5;
                        }
                        else if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == false)
                        {
                            //audioSource.clip = gameBGM[3];
                            //audioSource.PlayDelayed((float)timeDelta.TotalSeconds);
                            //audioSource.PlayDelayed((float)(102.0f + timeDelta.TotalSeconds));
                            audioSource.time = (float)(102.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 3;
                        }
                        break;
                    case 3:
                        audioSource.Stop();
                        if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == true)
                        {
                            audioSource.time = (float)(108.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 4;
                        }
                        else if (practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange == false)
                        {
                            //audioSource.clip = gameBGM[0];
                            //audioSource.PlayDelayed((float)timeDelta.TotalSeconds);
                            //audioSource.PlayDelayed((float)(96.0f + timeDelta.TotalSeconds));
                            audioSource.time = (float)(96.0f + timeDelta.TotalSeconds);
                            audioSource.PlayDelayed(0.0f);
                            switchBGM = 0;
                        }
                        break;
                    case 4:
                        audioSource.Stop();
                        audioSource.time = (float)(110.0f + timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        practiceStartButton1.GetComponent<PracticeStartButton1>().bgmChange = false;
                        switchBGM = 5;
                        break;
                    case 5:
                        audioSource.Stop();
                        audioSource.time = (float)(44.0f + timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        switchBGM = 10;
                        break;
                    case 10:
                        audioSource.Stop();
                        audioSource.time = (float)(46.0f + timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        switchBGM = 11;
                        break;
                    case 11:
                        audioSource.Stop();
                        audioSource.time = (float)(96.0f + timeDelta.TotalSeconds);
                        audioSource.PlayDelayed(0.0f);
                        switchBGM = 0;
                        break;
                    default:
                        break;
                }
                //Debug.Log($"timeDelta = {timeDelta.TotalSeconds}");
            }
        }
    }
}
