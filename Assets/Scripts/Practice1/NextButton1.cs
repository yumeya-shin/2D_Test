using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class NextButton1 : MonoBehaviour
{
    public Image image;
    public Sprite[] nextButton1 = new Sprite[3];
    public AudioClip onButton;
    //public StartButtonSEManager startButtonSEManager;
    //public NextButton1SEManager nextButton1SEManager;
    public GameObject nextButton1SEManager, BGMTimeManager;
    //public GameObject BGMTimeManagerScript;
    public int switchBGM;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        //startButtonSEManager = StartButtonSEManager.Instance;
        //nextButton1SEManager = NextButton1SEManager.Instance;
        nextButton1SEManager = GameObject.Find("NextButton1SEManager");
        BGMTimeManager = GameObject.Find("BGMTimeManager");
        //BGMTimeManagerScript = BGMTimeManager.GetComponents<BGMTimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        image.sprite = nextButton1[1];
        AudioSource.PlayClipAtPoint(onButton, new Vector3(0.0f, 0.0f, -10.0f));
    }

    void OnMouseOver()
    {
        if((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            image.sprite = nextButton1[2];
            if(Input.GetMouseButtonUp(0) == true)
            {
                //startButtonSEManager.PlayReleaseButton();
                nextButton1SEManager.GetComponent<NextButton1SEManager>().PlayReleaseButton();
                var BGMTimeManager = GameObject.Find("BGMTimeManager").GetComponent<BGMTimeManager>();
                switchBGM = BGMTimeManager.switchBGM;
                timeStart = BGMTimeManager.timeStart;
                timeNow = BGMTimeManager.timeNow;
                timeDelta = BGMTimeManager.timeDelta;
                timeSum = BGMTimeManager.timeSum;
                SceneManager.sceneLoaded += VariableCopy;
                SceneManager.LoadScene("Practice2");
                gameObject.SetActive(false);
            }
        }
        else
        {
            image.sprite = nextButton1[1];
        }
    }

    void OnMouseExit()
    {
        image.sprite = nextButton1[0];
    }

    private void VariableCopy(Scene scene, LoadSceneMode mode)
    {
        var BGMTimeManager2 = GameObject.Find("BGMTimeManager2").GetComponent<BGMTimeManager2>();
        BGMTimeManager2.isSceneChanged = true;
        //var BGMTimeManager = GameObject.Find("BGMTimeManager").GetComponent<BGMTimeManager>();
        //int switchBGM = BGMTimeManager.switchBGM;
        //DateTime timeStart = BGMTimeManager.timeStart, timeNow = BGMTimeManager.timeNow;
        BGMTimeManager2.switchBGM = switchBGM;
        BGMTimeManager2.timeStart = timeStart;
        BGMTimeManager2.timeNow = timeNow;
        BGMTimeManager2.timeDelta = timeDelta;
        BGMTimeManager2.timeSum = timeSum;
        SceneManager.sceneLoaded -= VariableCopy;

    }
}
