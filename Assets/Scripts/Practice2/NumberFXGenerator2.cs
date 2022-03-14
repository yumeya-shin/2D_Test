using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberFXGenerator2 : MonoBehaviour
{
    public int i;
    public bool isNumberFX;
    [SerializeField] public GameObject number;
    public RectTransform numberRectTransform;
    [SerializeField] public GameObject numberStarFX;
    [SerializeField] public GameObject numberCircleFX;
    public Vector3 numberFXPosition;
    readonly Vector2[] numberStarFXVector = new Vector2[5]
    {
        new Vector2(0.0f, 100.0f),
        new Vector2(95.1056516295153f, 30.9016994374947f),
        new Vector2(58.7785252292473f, -80.9016994374947f),
        new Vector2(-58.7785252292473f, -80.9016994374947f),
        new Vector2(-95.1056516295153f, 30.9016994374947f)
    };

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        isNumberFX = false;
        number = GameObject.Find("Number");
        numberRectTransform = number.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isNumberFX == true)
        {
            numberFXPosition = new Vector3(numberRectTransform.localPosition.x, numberRectTransform.localPosition.y, 0.0f);
            for(i = 0; i < 5; i++)
            {
                GameObject star = Instantiate(numberStarFX, numberFXPosition, Quaternion.identity);
                star.GetComponent<NumberStar>().SetMoveVector(numberStarFXVector[i]);
            }
            Instantiate(numberCircleFX, numberFXPosition, Quaternion.identity);
            isNumberFX = false;
        }
    }
}
