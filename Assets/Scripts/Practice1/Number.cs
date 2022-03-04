using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Number : MonoBehaviour
{
    public RectTransform number;
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta;
    public float positionX;
    public GameObject numberStarFXGenerator1;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.Now;
        timeNow = DateTime.MinValue;
        numberStarFXGenerator1 = GameObject.Find("NumberStarFXGenerator1");
    }

    // Update is called once per frame
    void Update()
    {
        if(timeDelta > TimeSpan.FromSeconds(0.000))
        {
            timeNow = DateTime.Now;
            timeDelta = timeNow - timeStart;
            positionX = 50.0f + ((float)timeDelta.TotalSeconds * 1080.0f / 3.500f);
            number.transform.position = new Vector2(positionX, 360.0f);
            if (Input.GetMouseButtonUp(0) == true)
            {
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().isNumberStarFX = true;
                numberStarFXGenerator1.GetComponent<NumberStarFXGenerator1>().numberStarFXPosition = new Vector3(positionX, 0.0f, 0.0f);
                if ((positionX >= 1093.0f) && (positionX < 1167.0f))
                {

                }
                else if ((positionX >= 1065.0f) && (positionX < 1195.0f))
                {

                }
                else if ((positionX >= 1038.0f) && (positionX < 1222.0f))
                {

                }
                else if ((positionX >= 1005.0f) && (positionX < 1255.0f))
                {

                }
                else if ((positionX >= 980.0f) && (positionX < 1280.0f))
                {

                }
                else if ((positionX >= 955.0f) && (positionX < 1305.0f))
                {

                }
                else if((positionX >= 930.0f) && (positionX < 1330.0f))
                {

                }
                else
                {

                }
                //Destroy(gameObject);
                gameObject.SetActive(false);
            }
            if (number.transform.position.x >= 1330)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
