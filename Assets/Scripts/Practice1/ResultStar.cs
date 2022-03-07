using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ResultStar : MonoBehaviour
{
    public DateTime timeStart, timeNow;
    public TimeSpan timeDelta, timeSum;
    [SerializeField] const double timeFX = 0.500;
    public int result = -1;
    public SpriteRenderer spriteRenderer;
    public Image image;
    public Sprite[] resultSprite = new Sprite[7];
    public Vector2 moveVector;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = DateTime.Now;
        timeNow = DateTime.Now;
        timeDelta = TimeSpan.FromSeconds(0.000f);
        timeSum = TimeSpan.FromSeconds(0.000f);
        spriteRenderer = GetComponent<SpriteRenderer>();
        if((result >= 0) && (result <= 6))
        {
            spriteRenderer.sprite = resultSprite[result];
        }
        
        //if ((result >= 0) && (result <= 6))
        //{
        //    image.sprite = resultSprite[result];
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if ((result >= 0) && (result <= 6))
        {
            image.sprite = resultSprite[result];
        }
        timeNow = DateTime.Now;
        timeDelta = timeNow - timeStart;
        timeSum += timeDelta;
        timeStart = timeNow;
        if (timeSum.TotalSeconds > 0)
        {
            if (timeSum.TotalSeconds <= timeFX)
            {
                transform.Translate(new Vector3((float)timeDelta.TotalSeconds * moveVector.x / (float)timeFX, (float)timeDelta.TotalSeconds * moveVector.y / (float)timeFX, 0.0f), Space.World);
                transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / (float)timeFX);
                transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / (float)timeFX, (float)timeDelta.TotalSeconds / (float)timeFX, 0.0f);
                spriteRenderer.color -= new Color(0.0f, 0.0f, 0.0f, (float)timeDelta.TotalSeconds / (float)timeFX);
            }
            else if (timeSum.TotalSeconds > timeFX)
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
