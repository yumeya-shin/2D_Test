using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Star1 : MonoBehaviour
{
    public DateTime time_start, time_now;
    public TimeSpan time_delta, time_sum;
    public SpriteRenderer sprite_renderer;
    
    // Start is called before the first frame update
    void Start()
    {
        time_start = DateTime.Now;
        time_now = DateTime.Now;
        time_delta = TimeSpan.FromMilliseconds(0);
        time_sum = TimeSpan.FromMilliseconds(0);
        //time_delta = TimeSpan.FromSeconds(0);
        //time_sum = TimeSpan.FromSeconds(0);
        sprite_renderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time_now = DateTime.Now;
        time_delta = (time_now - time_start);
        time_sum += time_delta;
        time_start = time_now;

        if(time_sum.Milliseconds > 0)
        //if(time_sum.Seconds > 0)
        {
            if (time_sum.Milliseconds <= 500)
            //if (time_sum.Seconds <= 10)
            {
                this.transform.Rotate(0, 0, (float)((float)(time_delta.Milliseconds) * (float)(-360) / 500.0f));
                //–â‘è“_
                this.transform.Translate(0, (float)((float)(time_delta.Milliseconds) * (float)(100) / 500.0f), 0, Space.World);
                //–â‘è“_‚±‚±‚Ü‚Å
                this.transform.localScale -= new Vector3((float)((float)(time_delta.Milliseconds) / 500.0f), (float)((float)(time_delta.Milliseconds) / 500.0f), 0.0f);
                sprite_renderer.color -= new Color(0, 0, 0, (float)((float)(time_delta.Milliseconds) / 500.0f));
            }
            else if (time_sum.Milliseconds > 500)
            //else if (time_sum.Seconds > 10)
            {
                Destroy(gameObject);
            }
        }
        Debug.Log($"time_sum.Milliseconds = {time_sum.Milliseconds}, time_delta.Milliseconds = {time_delta.Milliseconds}");
    }

}
