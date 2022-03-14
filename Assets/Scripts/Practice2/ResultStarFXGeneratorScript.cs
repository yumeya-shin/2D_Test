using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultStarFXGeneratorScript : MonoBehaviour
{
    public int i;
    public bool isResultStarFX = false;
    public int result = -1;
    public float positionX;
    public GameObject number, canvas;
    public RectTransform numberRectTransform, canvasRectTransform;
    [SerializeField] public GameObject resultStarFX;
    public Vector2[] resultStarFXPosition = new Vector2[8];
    readonly Vector2[] resultStarFXVector = new Vector2[8]
    {
        new Vector2(0.0f, 100.0f),
        new Vector2(70.7106781186548f, 70.7106781186548f),
        new Vector2(100.0f, 0.0f),
        new Vector2(70.7106781186548f, -70.7106781186548f),
        new Vector2(0.0f, -100.0f),
        new Vector2(-70.7106781186548f, -70.7106781186548f),
        new Vector2(-100.0f, 0.0f),
        new Vector2(-70.7106781186548f, 70.7106781186548f)
    };

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        number = GameObject.Find("Number");
        numberRectTransform = number.GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas3");
        canvasRectTransform = canvas.GetComponent<RectTransform>();
        if(isResultStarFX == true)
        {
            if((numberRectTransform.anchoredPosition.x >= 1093.0f) && (numberRectTransform.anchoredPosition.x < 1167.0f))
            {
                result = 6;
            }
            else if((numberRectTransform.anchoredPosition.x >= 1065.0f) && (numberRectTransform.anchoredPosition.x < 1195.0f))
            {
                result = 5;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1038.0f) && (numberRectTransform.anchoredPosition.x < 1222.0f))
            {
                result = 4;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1005.0f) && (numberRectTransform.anchoredPosition.x < 1255.0f))
            {
                result = 3;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 980.0f) && (numberRectTransform.anchoredPosition.x < 1280.0f))
            {
                result = 2;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 955.0f) && (numberRectTransform.anchoredPosition.x < 1305.0f))
            {
                result = 1;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 930.0f) && (numberRectTransform.anchoredPosition.x < 1330.0f))
            {
                result = 0;
            }
            switch(result)
            {
                case 6:
                    positionX = 340.0f;
                    break;
                case 5:
                    positionX = 413.0f;
                    break;
                case 4:
                    positionX = 443.0f;
                    break;
                case 3:
                    positionX = 394.0f;
                    break;
                case 2:
                    positionX = 261.0f;
                    break;
                case 1:
                    positionX = 243.0f;
                    break;
                case 0:
                    positionX = 152.0f;
                    break;
                default:
                    break;
            }
            resultStarFXPosition[0] = new Vector2(0.0f, 100.0f);
            resultStarFXPosition[1] = new Vector2(positionX, 100.0f);
            resultStarFXPosition[2] = new Vector2(positionX, 0.0f);
            resultStarFXPosition[3] = new Vector2(positionX, -100.0f);
            resultStarFXPosition[4] = new Vector2(0.0f, -100.0f);
            resultStarFXPosition[5] = new Vector2(-positionX, -100.0f);
            resultStarFXPosition[6] = new Vector2(-positionX, 0.0f);
            resultStarFXPosition[7] = new Vector2(-positionX, 100.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isResultStarFX == true)
        {
            if ((numberRectTransform.anchoredPosition.x >= 1093.0f) && (numberRectTransform.anchoredPosition.x < 1167.0f))
            {
                result = 6;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1065.0f) && (numberRectTransform.anchoredPosition.x < 1195.0f))
            {
                result = 5;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1038.0f) && (numberRectTransform.anchoredPosition.x < 1222.0f))
            {
                result = 4;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 1005.0f) && (numberRectTransform.anchoredPosition.x < 1255.0f))
            {
                result = 3;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 980.0f) && (numberRectTransform.anchoredPosition.x < 1280.0f))
            {
                result = 2;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 955.0f) && (numberRectTransform.anchoredPosition.x < 1305.0f))
            {
                result = 1;
            }
            else if ((numberRectTransform.anchoredPosition.x >= 930.0f) && (numberRectTransform.anchoredPosition.x < 1330.0f))
            {
                result = 0;
            }
            switch (result)
            {
                case 6:
                    positionX = 340.0f;
                    break;
                case 5:
                    positionX = 413.0f;
                    break;
                case 4:
                    positionX = 443.0f;
                    break;
                case 3:
                    positionX = 394.0f;
                    break;
                case 2:
                    positionX = 261.0f;
                    break;
                case 1:
                    positionX = 243.0f;
                    break;
                case 0:
                    positionX = 152.0f;
                    break;
                default:
                    break;
            }
            resultStarFXPosition[0] = new Vector2(0.0f, 100.0f);
            resultStarFXPosition[1] = new Vector2(positionX, 100.0f);
            resultStarFXPosition[2] = new Vector2(positionX, 0.0f);
            resultStarFXPosition[3] = new Vector2(positionX, -100.0f);
            resultStarFXPosition[4] = new Vector2(0.0f, -100.0f);
            resultStarFXPosition[5] = new Vector2(-positionX, -100.0f);
            resultStarFXPosition[6] = new Vector2(-positionX, 0.0f);
            resultStarFXPosition[7] = new Vector2(-positionX, 100.0f);
            for(i = 0; i < 8; i++)
            {
                GameObject Star = Instantiate(resultStarFX, resultStarFXPosition[i], Quaternion.identity);
                Star.GetComponent<ResultStar>().result = result;
                Star.GetComponent<ResultStar>().SetMoveVector(resultStarFXVector[i]);
            }
            isResultStarFX = false;
        }
    }
}
