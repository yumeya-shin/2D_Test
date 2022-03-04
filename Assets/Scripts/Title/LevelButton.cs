using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButton : MonoBehaviour
{
    public SpriteRenderer mainSpriteRenderer;
    public AudioClip onButton, releaseButton;
    public Sprite[] buttonTitle = new Sprite[3];
    public GameObject difficulty;
    public GameObject[] levelButton = new GameObject[4];
    public SpriteRenderer[] levelButtonSpriteRenderer = new SpriteRenderer[4];
    public Sprite[] buttonTitleLevel = new Sprite[4];

    // Start is called before the first frame update
    void Start()
    {
        mainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        difficulty = GameObject.Find("Difficulty");
        levelButton[0] = GameObject.Find("PracticeButton");
        levelButton[1] = GameObject.Find("Level1Button");
        levelButton[2] = GameObject.Find("Level2Button");
        levelButton[3] = GameObject.Find("Level3Button");
        levelButtonSpriteRenderer[0] = levelButton[0].GetComponent<SpriteRenderer>();
        levelButtonSpriteRenderer[1] = levelButton[1].GetComponent<SpriteRenderer>();
        levelButtonSpriteRenderer[2] = levelButton[2].GetComponent<SpriteRenderer>();
        levelButtonSpriteRenderer[3] = levelButton[3].GetComponent<SpriteRenderer>();
        //Debug.Log($"difficulty = {difficulty.GetComponent<Difficulty>().difficulty}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        mainSpriteRenderer.sprite = buttonTitle[1];
        AudioSource.PlayClipAtPoint(onButton, new Vector3(0, 0, -10));
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }

    void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            mainSpriteRenderer.sprite = buttonTitle[2];
            //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
            if(Input.GetMouseButtonUp(0) == true)
            {
                if(gameObject.name == "PracticeButton")
                {
                    difficulty.GetComponent<Difficulty>().difficulty = 0;
                    levelButtonSpriteRenderer[1].sprite = buttonTitleLevel[1];
                    levelButtonSpriteRenderer[2].sprite = buttonTitleLevel[2];
                    levelButtonSpriteRenderer[3].sprite = buttonTitleLevel[3];
                }
                else if (gameObject.name == "Level1Button")
                {
                    difficulty.GetComponent<Difficulty>().difficulty = 1;
                    levelButtonSpriteRenderer[0].sprite = buttonTitleLevel[0];
                    levelButtonSpriteRenderer[2].sprite = buttonTitleLevel[2];
                    levelButtonSpriteRenderer[3].sprite = buttonTitleLevel[3];
                }
                else if(gameObject.name == "Level2Button")
                {
                    difficulty.GetComponent<Difficulty>().difficulty = 2;
                    levelButtonSpriteRenderer[0].sprite = buttonTitleLevel[0];
                    levelButtonSpriteRenderer[1].sprite = buttonTitleLevel[1];
                    levelButtonSpriteRenderer[3].sprite = buttonTitleLevel[3];
                }
                else if(gameObject.name == "Level3Button")
                {
                    difficulty.GetComponent<Difficulty>().difficulty = 3;
                    levelButtonSpriteRenderer[0].sprite = buttonTitleLevel[0];
                    levelButtonSpriteRenderer[1].sprite = buttonTitleLevel[1];
                    levelButtonSpriteRenderer[2].sprite = buttonTitleLevel[2];
                }
                AudioSource.PlayClipAtPoint(releaseButton, new Vector3(0, 0, -10));
                Debug.Log($"difficulty = {difficulty.GetComponent<Difficulty>().difficulty}");
            }
        }
        else
        {
            mainSpriteRenderer.sprite = buttonTitle[1];
            //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
        }
    }

    void OnMouseExit()
    {
        if(((gameObject.name == "PracticeButton") && (difficulty.GetComponent<Difficulty>().difficulty == 0))
            || ((gameObject.name == "Level1Button") && (difficulty.GetComponent<Difficulty>().difficulty == 1))
            || ((gameObject.name == "Level2Button") && (difficulty.GetComponent<Difficulty>().difficulty == 2))
            || ((gameObject.name == "Level3Button") && (difficulty.GetComponent<Difficulty>().difficulty == 3)))
        {
            mainSpriteRenderer.sprite = buttonTitle[1];
        }
        else
        {
            mainSpriteRenderer.sprite = buttonTitle[0];
        }
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }
}
