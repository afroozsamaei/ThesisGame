using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {


    public GameObject[] smallBoxes = new GameObject[numSmallBoxes];
    public GameObject[] obstacles = new GameObject[4];
    public Text[] boxesHeight = new Text[4];
    private const int numSmallBoxes = 5;
    public static int finalBoxes;
    public float currentHeight;
    private bool[] hitsObject = new bool[4];
    public static int stars;
    public static float[] inputNum = new float[4];


    private void Start()
    {
        for (int i=0; i<hitsObject.Length; i++)
        {
            hitsObject[i] = true;
        }
        currentHeight = 2.5f;
        inputNum[0] = currentHeight;
        
    }

    public void Load()
    {
        inputNum[ChallengeScreenManager.questionsCount - 1] += 0.1f;
        if (inputNum[ChallengeScreenManager.questionsCount - 1] >= 2.5f)
        {
            inputNum[ChallengeScreenManager.questionsCount - 1] = 2.5f;
        }
        currentHeight = inputNum[ChallengeScreenManager.questionsCount - 1];
        boxesHeight[ChallengeScreenManager.questionsCount - 1].text = "Current Height of the Boxes:  "+ currentHeight.ToString() + "  meters";   
    }

    public void Unload()
    {
        inputNum[ChallengeScreenManager.questionsCount - 1] -= 0.1f;
        if (inputNum[ChallengeScreenManager.questionsCount - 1] <= 1f)
        {
            inputNum[ChallengeScreenManager.questionsCount - 1] = 1f;
        }
        currentHeight = inputNum[ChallengeScreenManager.questionsCount - 1];
        boxesHeight[ChallengeScreenManager.questionsCount - 1].text = "Current Height of the Boxes:  " + currentHeight.ToString() + "  meters";
    }

    public void numberEnter1()
    {
        if (inputNum[0] >= 2.5f)
        {
            finalBoxes = 5;
            hitsObject[0] = true;
        }
        else if(inputNum[0]<2.5f && inputNum[0] >= 2.3f)
        {
            finalBoxes = 4;
            hitsObject[0] = true;
        }
        else if(inputNum[0]<2.3f && inputNum[0] >= 2.1f)
        {
            finalBoxes = 3;
        if (inputNum[0] < 2.11f && inputNum[0]>2.09f)
            {
                hitsObject[0] = false;
            }
            else
            {
                hitsObject[0] = true;
            }
            
        }
        else if(inputNum[0]<2.1f && inputNum[0] >= 1.9f)
        {
            finalBoxes = 2;
            hitsObject[0] = false;
        }
        else if (inputNum[0]<1.9f && inputNum[0] >= 1.7f)
        {
            finalBoxes = 1;
            hitsObject[0] = false;
        }
        else if (inputNum[0] <1.7f && inputNum[0] >= 1.5f)
        {
            finalBoxes = 0;
            hitsObject[0] = false;
        }
        else
        {
            finalBoxes = 0;
            hitsObject[0] = false;
        }


        for (int i = 0; i < smallBoxes.Length; i++)
        {
            if (i <= finalBoxes-1)
            {
                smallBoxes[i].SetActive(true);
            }
            else
            {
                smallBoxes[i].SetActive(false);
            }
        }

        if (!hitsObject[0])
        {
            obstacles[0].SetActive(false);
        }
        else
        {
            obstacles[0].SetActive(true);
        }
        inputNum[1] = currentHeight;
        boxesHeight[1].text = "Current Height of the Boxes:  " + currentHeight.ToString() + "  meters";
    }

    public void numberEnter2()
    {
        if (inputNum[1] >= 2.5f)
        {
            finalBoxes = 5;
            hitsObject[1] = true;
        }
        else if (inputNum[1] < 2.5f && inputNum[1] >= 2.3f)
        {
            finalBoxes = 4;
            hitsObject[1] = true;
        }
        else if (inputNum[1] < 2.3f && inputNum[1] >= 2.1f)
        {
            finalBoxes = 3;
            hitsObject[1] = true;
        }
        else if (inputNum[1] < 2.1f && inputNum[1] >= 1.9f)
        {
            finalBoxes = 2;
            if (inputNum[1] < 1.91f && inputNum[1] > 1.89f)
            {
                hitsObject[1] = false;
            }
            else
            {
                hitsObject[1] = true;
            }
            
        }
        else if (inputNum[1] < 1.9f && inputNum[1] >= 1.7f)
        {
            finalBoxes = 1;
            hitsObject[1] = false;
        }
        else if (inputNum[1] < 1.7f && inputNum[1] >= 1.5f)
        {
            finalBoxes = 0;
            hitsObject[1] = false;
        }
        else
        {
            finalBoxes = 0;
            hitsObject[1] = false;
        }

        for (int i = 0; i < smallBoxes.Length; i++)
        {
            if (i <= finalBoxes - 1)
            {
                smallBoxes[i].SetActive(true);
            }
            else
            {
                smallBoxes[i].SetActive(false);
            }
        }
        if (!hitsObject[1])
        {
            obstacles[1].SetActive(false);
        }
        else
        {
            obstacles[1].SetActive(true);
        }
        inputNum[2] = currentHeight;
        boxesHeight[2].text = "Current Height of the Boxes:  " + currentHeight.ToString() + "  meters";
    }

    public void numberEnter3()
    {

        if (inputNum[2] >= 2.5f)
        {
            finalBoxes = 5;
            hitsObject[2] = true;
        }
        else if (inputNum[2] < 2.5f && inputNum[2] >= 2.3f)
        {
            finalBoxes = 4;
            hitsObject[2] = true;
        }
        else if (inputNum[2] < 2.3f && inputNum[2] >= 2.1f)
        {
            finalBoxes = 3;
            hitsObject[2] = true;
        }
        else if (inputNum[2] < 2.1f && inputNum[2] >= 1.9f)
        {
            finalBoxes = 2;
            if (inputNum[2] < 1.91f && inputNum[2] > 1.89f)
            {
                hitsObject[2] = false;
            }
            else
            {
                hitsObject[2] = true;
            }
        }
        else if (inputNum[2] < 1.9f && inputNum[2] >= 1.7f)
        {
            finalBoxes = 1;
            hitsObject[2] = false;
        }
        else if (inputNum[2] < 1.7f && inputNum[2] >= 1.5f)
        {
            finalBoxes = 0;
            hitsObject[2] = false;
        }
        else
        {
            finalBoxes = 0;
            hitsObject[2] = false;
        }


        for (int i = 0; i < smallBoxes.Length; i++)
        {
            if (i <= finalBoxes - 1)
            {
                smallBoxes[i].SetActive(true);
            }
            else
            {
                smallBoxes[i].SetActive(false);
            }
        }
        if (!hitsObject[2])
        {
            obstacles[2].SetActive(false);
        }
        else
        {
            obstacles[2].SetActive(true);
        }
        inputNum[3] = currentHeight;
        boxesHeight[3].text = "Current Height of the Boxes:  " +  currentHeight.ToString() + "  meters";
    }

    public void numberEnter4()
    {

        if (inputNum[3] >= 2.5f)
        {
            finalBoxes = 5;
            hitsObject[3] = true;
        }
        else if (inputNum[3] < 2.5f && inputNum[3] >= 2.3f)
        {
            finalBoxes = 4;
            hitsObject[3] = false;
        }
        else if (inputNum[3] < 2.3f && inputNum[3] >= 2.1f)
        {
            finalBoxes = 3;
            hitsObject[3] = false;
        }
        else if (inputNum[3] < 2.1f && inputNum[3] >= 1.9f)
        {
            finalBoxes = 2;
            hitsObject[3] = false;
        }
        else if (inputNum[3] < 1.9f && inputNum[3] >= 1.7f)
        {
            finalBoxes = 1;
            hitsObject[3] = false;
        }
        else if (inputNum[3] < 1.7f && inputNum[3] >= 1.5f)
        {
            finalBoxes = 0;
            hitsObject[3] = false;
        }
        else
        {
            finalBoxes = 0;
            hitsObject[3] = false;
        }


        for (int i = 0; i < smallBoxes.Length; i++)
        {
            if (i <= finalBoxes - 1)
            {
                smallBoxes[i].SetActive(true);
            }
            else
            {
                smallBoxes[i].SetActive(false);
            }
        }
        if (!hitsObject[3])
        {
            obstacles[3].SetActive(false);
        }
        else
        {
            obstacles[3].SetActive(true);
        }

        CalculateScore();
    }

    public void CalculateScore()
    {
        float score = 0;
        for (int i = 0; i < inputNum.Length; i++)
        {
            score += inputNum[i];
        }

        if (score >=8.3f)
        {
            stars = 3;
        }
        else if (score <8.3f && score > 7f)
        {
            stars = 2;
        }
        else if (score <= 7f && score > 6f)
        {
            stars = 1;
        }
        else
        {
            stars = 0;
        }
    }
}
