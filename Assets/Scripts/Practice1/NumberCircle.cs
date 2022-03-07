using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NumberCircle : MonoBehaviour
{
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    public SpriteRenderer spriteRenderer;
    [SerializeField] const double timeFX = 0.500;
    public bool isNumberCircle = false;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.Now;
        timeNow = DateTime.Now;
        timeDelta = TimeSpan.FromSeconds(0.000f);
        timeSum = TimeSpan.FromSeconds(0.000f);
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timeNow = DateTime.Now;
        timeDelta = timeNow - timeStart;
        timeSum += timeDelta;
        timeStart = timeNow;
        if (timeSum.TotalSeconds > 0)
        {
            if (timeSum.TotalSeconds <= timeFX)
            {
                transform.localScale += new Vector3((float)timeDelta.TotalSeconds * 140.0f / (float)(timeFX), (float)timeDelta.TotalSeconds * 140.0f / (float)(timeFX), 0.0f);
                spriteRenderer.color -= new Color(0, 0, 0, (float)timeDelta.TotalSeconds / (float)(timeFX));
            }
            else if (timeSum.TotalSeconds > timeFX)
            {
                Destroy(gameObject);
            }
        }
        //Debug.Log($"timeSum.TotalSeconds = {timeSum.TotalSeconds}");
    }
}
