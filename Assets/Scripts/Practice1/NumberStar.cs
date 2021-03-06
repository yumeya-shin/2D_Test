using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberStar : MonoBehaviour
{
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public SpriteRenderer spriteRenderer;
    public Vector2 moveVector;
    [SerializeField] const double timeFX = 0.500;
    public bool isNumberStar = false;

    // Start is called before the first frame update
    void Start()
    {
        /*timeStart = DateTime.MinValue;
        timeNow = DateTime.MaxValue;*/
        timeStart = DateTime.Now;
        timeNow = DateTime.Now;
        timeDelta = TimeSpan.FromSeconds(0.000f);
        timeSum = TimeSpan.FromSeconds(0.000f);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(isNumberStar == true)
        {
            timeStart = DateTime.Now;
            isNumberStar = false;
        }*/
        timeNow = DateTime.Now;
        timeDelta = timeNow - timeStart;
        timeSum += timeDelta;
        timeStart = timeNow;
        if(timeSum.TotalSeconds > 0)
        {
            if(timeSum.TotalSeconds <= timeFX)
            {
                transform.Translate(new Vector3((float)timeDelta.TotalSeconds * moveVector.x / (float)timeFX, (float)timeDelta.TotalSeconds * moveVector.y / (float)timeFX, 0.0f), Space.World);
                transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / (float)timeFX);
                transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / (float)timeFX, (float)timeDelta.TotalSeconds / (float)timeFX, 0.0f);
                spriteRenderer.color -= new Color(0.0f, 0.0f, 0.0f, (float)timeDelta.TotalSeconds / (float)timeFX);
                /*if (gameObject.name == "NumberCircle")
                {
                    transform.localScale += new Vector3((float)timeDelta.TotalSeconds * 140.0f / 5.500f, (float)timeDelta.TotalSeconds * 140.0f / 5.500f, 0.0f);
                }*/
            }
            else if(timeSum.TotalSeconds > timeFX)
            {
                Destroy(gameObject);
            }
        }
    }

    public void SetMoveVector(Vector2 vector)
    {
        moveVector = vector;
    }
}
