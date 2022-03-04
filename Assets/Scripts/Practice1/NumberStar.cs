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
        if(timeSum.TotalSeconds > 0)
        {
            if(timeSum.TotalSeconds <= 0.500)
            {
                /*if(gameObject.name == "NumberStar")
                {*/
                    transform.Translate(new Vector3((float)timeDelta.TotalSeconds * moveVector.x / 0.500f, (float)timeDelta.TotalSeconds * moveVector.y / 0.500f, 0.0f), Space.World);
                    transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / 0.500f);
                    transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / 0.500f, (float)timeDelta.TotalSeconds / 0.500f, 0.0f);
                /*}
                else if(gameObject.name == "NumberStar2")
                {
                    transform.Translate((float)timeDelta.TotalSeconds * 100.0f * 0.951056516295153f / 5.500f, (float)timeDelta.TotalSeconds * 100.0f * 0.309016994374947f / 5.500f, 0.0f, Space.World);
                    transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / 5.500f);
                    transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / 5.500f, (float)timeDelta.TotalSeconds / 5.500f, 0.0f);
                }
                else if (gameObject.name == "NumberStar3")
                {
                    transform.Translate((float)timeDelta.TotalSeconds * 100.0f * 0.587785252292473f / 5.500f, (float)timeDelta.TotalSeconds * 100.0f * -0.809016994374947f / 5.500f, 0.0f, Space.World);
                    transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / 5.500f);
                    transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / 5.500f, (float)timeDelta.TotalSeconds / 5.500f, 0.0f);
                }
                else if (gameObject.name == "NumberStar4")
                {
                    transform.Translate((float)timeDelta.TotalSeconds * 100.0f * -0.587785252292473f / 5.500f, (float)timeDelta.TotalSeconds * 100.0f * -0.809016994374947f / 5.500f, 0.0f, Space.World);
                    transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / 5.500f);
                    transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / 5.500f, (float)timeDelta.TotalSeconds / 5.500f, 0.0f);
                }
                else if (gameObject.name == "NumberStar5")
                {
                    transform.Translate((float)timeDelta.TotalSeconds * 100.0f * -0.951056516295153f / 5.500f, (float)timeDelta.TotalSeconds * 100.0f * 0.309016994374947f / 5.500f, 0.0f, Space.World);
                    transform.Rotate(0.0f, 0.0f, (float)timeDelta.TotalSeconds * -360.0f / 5.500f);
                    transform.localScale -= new Vector3((float)timeDelta.TotalSeconds / 5.500f, (float)timeDelta.TotalSeconds / 5.500f, 0.0f);
                }
                else 
                if (gameObject.name == "NumberCircle")
                {
                    transform.localScale += new Vector3((float)timeDelta.TotalSeconds * 140.0f / 5.500f, (float)timeDelta.TotalSeconds * 140.0f / 5.500f, 0.0f);
                }*/
                spriteRenderer.color -= new Color(0.0f, 0.0f, 0.0f, (float)timeDelta.TotalSeconds / 0.500f);
            }
            else if(timeSum.TotalSeconds > 0.500)
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
