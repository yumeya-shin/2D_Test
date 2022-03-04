using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberStarFXGenerator1 : MonoBehaviour
{
    public int i;
    public bool isNumberStarFX;
    //public GameObject[] numberStarFX = new GameObject[5];
    public GameObject numberStarFXPre;
    public GameObject numberCircleFX;
    public GameObject targetObject;
    public Vector3 numberStarFXPosition;
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
        isNumberStarFX = false;
        targetObject = GameObject.Find("Number");
    }

    // Update is called once per frame
    void Update()
    {
        if(isNumberStarFX == true)
        {
            //Vector3 numberStarFXPosition = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z);
            for(i = 1; i <= 5; i++)
            {
                GameObject objectPre = Instantiate(numberStarFXPre, Camera.main.ScreenToWorldPoint(numberStarFXPosition), Quaternion.identity);
                objectPre.GetComponent<NumberStar>().SetMoveVector(numberStarFXVector[i - 1]);
            }
            Instantiate(numberCircleFX, Camera.main.ScreenToWorldPoint(numberStarFXPosition), Quaternion.identity);
            isNumberStarFX = false;
        }
    }
}

/*internal struct NewStruct
{
    public float Item1;
    public float Item2;
    public float Item3;

    public NewStruct(float item1, float item2, float item3)
    {
        Item1 = item1;
        Item2 = item2;
        Item3 = item3;
    }

    public override bool Equals(object obj)
    {
        return obj is NewStruct other &&
               Item1 == other.Item1 &&
               Item2 == other.Item2 &&
               Item3 == other.Item3;
    }

    public override int GetHashCode()
    {
        int hashCode = 341329424;
        hashCode = hashCode * -1521134295 + Item1.GetHashCode();
        hashCode = hashCode * -1521134295 + Item2.GetHashCode();
        hashCode = hashCode * -1521134295 + Item3.GetHashCode();
        return hashCode;
    }

    public void Deconstruct(out float item1, out float item2, out float item3)
    {
        item1 = Item1;
        item2 = Item2;
        item3 = Item3;
    }

    public static implicit operator (float, float, float)(NewStruct value)
    {
        return (value.Item1, value.Item2, value.Item3);
    }

    public static implicit operator NewStruct((float, float, float) value)
    {
        return new NewStruct(value.Item1, value.Item2, value.Item3);
    }
}*/