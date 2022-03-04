using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickFXGenerator : MonoBehaviour
{
    public int i;
    public Vector3 mouse_pos;
    public GameObject[] click_fx_star = new GameObject[5];
    public GameObject click_fx_circle;
    [SerializeField]
    GameObject StarPre;

    [SerializeField]
    List<GameObject> debugList = new List<GameObject>();
    readonly Vector2[] moveVecList = new Vector2[5] {
        new Vector2(0.0f,100.0f),
        new Vector2(95.1056516295153f, 30.9016994374947f),
        new Vector2(58.7785252292473f, -80.9016994374947f),
        new Vector2(-58.7785252292473f, -80.9016994374947f),
        new Vector2(-95.1056516295153f, 30.9016994374947f)
    };
        

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        i = 0;
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 10.0f;
        DontDestroyOnLoad(this);
        //click_fx_star[0] = GameObject.Find("Star1");
        //click_fx_star[1] = GameObject.Find("Star2");
        //click_fx_star[2] = GameObject.Find("Star3");
        //click_fx_star[3] = GameObject.Find("Star4");
        //click_fx_star[4] = GameObject.Find("Star5");
        //click_fx_circle = GameObject.Find("Circle");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0) == true) {
            mouse_pos = Input.mousePosition;
            mouse_pos.z = 10.0f;
            for (i = 0; i < 5; i++)
            {
                //Instantiate(click_fx_star[i], Camera.main.ScreenToWorldPoint(mouse_pos), Quaternion.identity);
                var obj = Instantiate(StarPre, Camera.main.ScreenToWorldPoint(mouse_pos), Quaternion.identity);
                obj.GetComponent<StarMove>().SetMoveVec(moveVecList[i]);
                //debugList.Add(obj);
            }
            Instantiate(click_fx_circle, Camera.main.ScreenToWorldPoint(mouse_pos), Quaternion.identity);
        }
    }
}
