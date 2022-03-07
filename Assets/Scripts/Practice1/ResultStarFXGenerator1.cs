using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultStarFXGenerator1 : MonoBehaviour
{
    public int i;
    public bool isResultStarFX;
    public int result;
    public float resultX;
    [SerializeField] GameObject resultStarFXpre;
    [SerializeField] Vector3[] resultStarFXPosision = new Vector3[8];
    [SerializeField] readonly Vector2[] resultStarFXVector = new Vector2[8]
    {
        new Vector2(0.0f, 100.0f),
        new Vector2(70.7106781186548f, 70.7106781186548f),
        new Vector2(100.0f, 0.0f),
        new Vector2(70.7106781186548f, -70.7106781186548f),
        new Vector2(0.0f, -100.0f),
        new Vector2(-70.7106781186548f, -70.7106781186548f),
        new Vector2(-100.0f, 0.0f),
        new Vector2(-70.7106781186548f, 70.7106781186548f),
    };

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        isResultStarFX = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isResultStarFX == true)
        {
            resultStarFXPosision[0] = new Vector3(0.0f, 100.0f, 0.0f);
            resultStarFXPosision[4] = new Vector3(0.0f, -100.0f, 0.0f);
            switch(result)
            {
                case 6:
                    resultX = 340.0f;
                    break;
                case 5:
                    resultX = 413.0f;
                    break;
                case 4:
                    resultX = 443.0f;
                    break;
                case 3:
                    resultX = 394.0f;
                    break;
                case 2:
                    resultX = 261.0f;
                    break;
                case 1:
                    resultX = 243.0f;
                    break;
                case 0:
                    resultX = 152.0f;
                    break;
                default:
                    break;
            }
            resultStarFXPosision[1] = new Vector3(resultX, 100.0f, 0.0f);
            resultStarFXPosision[2] = new Vector3(resultX, 0.0f, 0.0f);
            resultStarFXPosision[3] = new Vector3(resultX, -100.0f, 0.0f);
            resultStarFXPosision[5] = new Vector3(-resultX, -100.0f, 0.0f);
            resultStarFXPosision[6] = new Vector3(-resultX, 0.0f, 0.0f);
            resultStarFXPosision[7] = new Vector3(-resultX, 100.0f, 0.0f);

            for (i = 1; i <= 8; i++)
            {
                GameObject objectPre = Instantiate(resultStarFXpre, resultStarFXPosision[i - 1], Quaternion.identity);
                objectPre.GetComponent<ResultStar>().result = result;
                objectPre.GetComponent<ResultStar>().SetMoveVector(resultStarFXVector[i - 1]);
            }
            isResultStarFX = false;
        }
    }

    public void ResetSetting()
    {
        result = -1;
    }
}
