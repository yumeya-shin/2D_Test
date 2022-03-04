using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public SpriteRenderer mainSpriteRenderer;
    public AudioClip onButton;
    public AudioClip releaseButtonError;
    public Sprite[] buttonTitle = new Sprite[3];
    public GameObject difficulty, unimplementedTMP;
    public StartButtonSEManager startButtonSEManager;
    [SerializeField] GameObject noDifficultySelected;

    // Start is called before the first frame update
    void Start()
    {
        mainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        difficulty = GameObject.Find("Difficulty");
        noDifficultySelected = GameObject.Find("NoDifficultySelectedTMP");
        noDifficultySelected.SetActive(false);
        unimplementedTMP = GameObject.Find("UnimplementedTMP");
        unimplementedTMP.SetActive(false);
        startButtonSEManager = StartButtonSEManager.Instance;
        //DontDestroyOnLoad(gameObject);
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
                //if(gameObject.name == "PracticeButton")
                //{
                //    difficulty.GetComponent<Difficulty>().difficulty = 0;
                //}
                //else if (gameObject.name == "Level1Button")
                //{
                //    difficulty.GetComponent<Difficulty>().difficulty = 1;
                //}
                //else if(gameObject.name == "Level2Button")
                //{
                //    difficulty.GetComponent<Difficulty>().difficulty = 2;
                //}
                //else if(gameObject.name == "Level3Button")
                //{
                //    difficulty.GetComponent<Difficulty>().difficulty = 3;
                //}
                //else if (gameObject.name == "StartButton")
                //{
                switch (difficulty.GetComponent<Difficulty>().difficulty)
                {
                    case -1:
                        noDifficultySelected.SetActive(true);
                        noDifficultySelected.GetComponent<NoDifficultySelectedTMP>().isSetActive = true;
                        AudioSource.PlayClipAtPoint(releaseButtonError, new Vector3(0, 0, -10));
                        break;
                    case 0:
                        startButtonSEManager.PlayReleaseButton();
                        gameObject.SetActive(false);
                        SceneManager.LoadScene("Practice1");
                        //Destroy(this.gameObject, 1.0f);
                        break;
                    case 1:
                        unimplementedTMP.SetActive(true);
                        unimplementedTMP.GetComponent<UnimplementedTMP>().isSetActive = true;
                        AudioSource.PlayClipAtPoint(releaseButtonError, new Vector3(0, 0, -10));
                        break;
                    case 2:
                        unimplementedTMP.SetActive(true);
                        unimplementedTMP.GetComponent<UnimplementedTMP>().isSetActive = true;
                        AudioSource.PlayClipAtPoint(releaseButtonError, new Vector3(0, 0, -10));
                        break;
                    case 3:
                        unimplementedTMP.SetActive(true);
                        unimplementedTMP.GetComponent<UnimplementedTMP>().isSetActive = true;
                        AudioSource.PlayClipAtPoint(releaseButtonError, new Vector3(0, 0, -10));
                        break;
                    default:
                        break;
                }
                //}
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
        mainSpriteRenderer.sprite = buttonTitle[0];
        //Debug.Log($"mainSpriteRenderer.sprite = {mainSpriteRenderer.sprite}");
    }
}
