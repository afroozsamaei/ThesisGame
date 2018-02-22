using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameHandler : MonoBehaviour {

    public GameObject descriptionScreen;
    public GameObject inventory;
    public GameObject scoreScreen;
    public GameObject inWaterScreen;

    public GameObject[] starImages = new GameObject[3];
    public Text feedback;

    public Button select;
    public Button start;

    public Camera carCamera;
    public Camera overheadCamera;



    private AudioSource sound;
    public AudioClip startEngine;

    public static bool gameIsOver;
    public static bool canMove;
    public static bool cameraMove;


    void Awake()
    {

        inventory.SetActive(false);
        scoreScreen.SetActive(false);
        inWaterScreen.SetActive(false);
        descriptionScreen.SetActive(true);

        for (int i = 0; i < starImages.Length; i++)
        {
            starImages[i].SetActive(false);
        }

        carCamera.enabled = false;
        overheadCamera.enabled = true;

        Button btnStart = start.GetComponent<Button>();
        btnStart.onClick.AddListener(() => {
            descriptionScreen.SetActive(false);
            canMove = true;
            gameIsOver = false;
            sound.PlayOneShot(startEngine, 1f);
            carCamera.enabled = true;
            overheadCamera.enabled = false;
            inventory.SetActive(true);
        });

        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (ImpactManager.inWater)
        {
            gameIsOver = true;
            canMove = false;
            inWaterScreen.SetActive(true);
        }

        if (ImpactManager.atDestination)
        {
            gameIsOver = true;
            canMove = false;
            scoreScreen.SetActive(true);

            switch (InputManager.stars)
            {
                case 3:
                    feedback.text = "Excellent!";
                    break;
                case 2:
                    feedback.text = "Very Good! Try again to get 3 stars!";
                    break;
                case 1:
                    feedback.text = "Good! Try again to get more stars!";
                    break;
                case 0:
                    feedback.text = "You didn't get any stars! Try again to get some!";
                    break;
            }

            if (InputManager.stars > 0)
            {
                for (int i = 0; i < InputManager.stars; i++)
                {
                    starImages[i].SetActive(true);
                }
            }
        }


        if (Input.GetKeyDown(KeyCode.Escape))
          {
            QuitGame();
          }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCamera();
        }      
    }


    public void ToggleCamera()
    {
        if (carCamera.enabled)
        {
            carCamera.enabled = false;
            overheadCamera.enabled = true;

            canMove = false;
            cameraMove = true;
        }

        else
        {
            carCamera.enabled = true;
            overheadCamera.enabled = false;

            canMove = true;
            cameraMove = false;
        }
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(ChangeLevel.currentScene);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main");
    }

}
