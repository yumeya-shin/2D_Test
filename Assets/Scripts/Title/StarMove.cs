using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class StarMove : MonoBehaviour
{
    public DateTime time_start, time_now;
    public TimeSpan time_delta, time_sum;
    public SpriteRenderer sprite_renderer;
    const int moveTime = 500;
    Vector2 moveVec;
    
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
        //StartCoroutine(MoveStart(moveVec));
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        time_now = DateTime.Now;
        time_delta = (time_now - time_start);
        time_sum += time_delta;
        time_start = time_now;

        if (time_sum.Milliseconds > 0)
        //if(time_sum.Seconds > 0)
        {
            if (time_sum.Milliseconds <= 500)
            //if (time_sum.Seconds <= 10)
            {
                this.transform.Rotate(0, 0, time_delta.Milliseconds * -360.0f / moveTime);
                //問題点
                this.transform.Translate(new Vector3(time_delta.Milliseconds * moveVec.x / 500, time_delta.Milliseconds * moveVec.y / 500, 0.0f), Space.World);
                //問題点ここまで
                this.transform.localScale -= time_delta.Milliseconds*Vector3.one / moveTime;
                sprite_renderer.color -= new Color(0, 0, 0, time_delta.Milliseconds*1.0f / 500);
            }
            else if (time_sum.Milliseconds > 500)
            //else if (time_sum.Seconds > 10)
            {
                Destroy(gameObject);
            }
        }
        //Debug.Log($"time_sum.Milliseconds = {time_sum.Milliseconds}, time_delta.Milliseconds = {time_delta.Milliseconds}");
    }
    public void SetMoveVec(Vector2 vec)
    {
        moveVec = vec;
    }
    //IEnumerator MoveStart(Vector2 direction)
    //{
    //    int timer = 0;
    //    //var wait = new WaitForSeconds(0.001f);
    //    while (timer < moveTime)
    //    {
            
    //        this.transform.Rotate(0, 0, -360.0f / moveTime);
    //        //問題点
    //        this.transform.Translate(new Vector3(direction.x / 500, direction.y / 500, 0.0f), Space.World);
    //        //問題点ここまで
    //        this.transform.localScale -= Vector3.one / moveTime;
    //        sprite_renderer.color -= new Color(0, 0, 0, 1.0f / 500);
    //        yield return null;
    //        timer += 16;
    //    }
    //    Destroy(gameObject);

    //}
}
