using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextButton1 : MonoBehaviour
{
    public Image image;
    public Sprite[] nextButton1 = new Sprite[3];
    public AudioClip onButton;
    //public StartButtonSEManager startButtonSEManager;
    //public NextButton1SEManager nextButton1SEManager;
    public GameObject nextButton1SEManager;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        //startButtonSEManager = StartButtonSEManager.Instance;
        //nextButton1SEManager = NextButton1SEManager.Instance;
        nextButton1SEManager = GameObject.Find("NextButton1SEManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        image.sprite = nextButton1[1];
        AudioSource.PlayClipAtPoint(onButton, new Vector3(0.0f, 0.0f, -10.0f));
    }

    void OnMouseOver()
    {
        if((Input.GetMouseButtonDown(0) == true) || (Input.GetMouseButton(0) == true) || (Input.GetMouseButtonUp(0) == true))
        {
            image.sprite = nextButton1[2];
            if(Input.GetMouseButtonUp(0) == true)
            {
                //startButtonSEManager.PlayReleaseButton();
                nextButton1SEManager.GetComponent<NextButton1SEManager>().PlayReleaseButton();
                gameObject.SetActive(false);
                SceneManager.LoadScene("Practice2");
            }
        }
        else
        {
            image.sprite = nextButton1[1];
        }
    }

    void OnMouseExit()
    {
        image.sprite = nextButton1[0];
    }
}
