using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeScreenManager : MonoBehaviour {

    public GameObject[] questionScreen = new GameObject[4];
    public GameObject[] tempButton = new GameObject[4];

    public static int questionsCount;

    public Text warning;
    public Text questionScreenText;

    void Start () {

        questionsCount = 1;
        warning.enabled = false;

        for (int i = 0; i < 4; i++)
        {
            questionScreen[i].SetActive(false);
            tempButton[i].SetActive(false);
        }
    }

    private void Update()
    {

            if (WWebViewDemo.buttonCheck[questionsCount-1])
            {
                tempButton[questionsCount-1].SetActive(true);
            }
            else
            {
                tempButton[questionsCount-1].SetActive(false);
            }
       

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Question1"))
        {
                GameHandler.canMove = false;
                questionScreen[0].SetActive(true);
                GetComponent<Rigidbody>().transform.Translate(0, 0, 10);
                questionsCount = 1;
        }

        if (other.gameObject.CompareTag("Question2"))
        {
            GameHandler.canMove = false;
            questionScreen[1].SetActive(true);
            GetComponent<Rigidbody>().transform.Translate(0, 0, 10);
            questionsCount = 2;
        }

        if (other.gameObject.CompareTag("Question3"))
        {
            GameHandler.canMove = false;
            questionScreen[2].SetActive(true);
            GetComponent<Rigidbody>().transform.Translate(0, 0, 10);
            questionsCount = 3;

        }

        if (other.gameObject.CompareTag("Question4"))
        {
            GameHandler.canMove = false;
            questionScreen[3].SetActive(true);
            GetComponent<Rigidbody>().transform.Translate(0, 0, 10);
            questionsCount = 4;
        }


        //if (other.gameObject.CompareTag("Warning"))
        //{
        //    if (!BoxManager.pickedUpBoxes)
        //    {
        //        StartCoroutine(ShowMessage("Collect some boxes for a higher score!", 3));
        //    }
        //    else
        //    {
        //        other.gameObject.SetActive(false);
        //    }
        //}
    }

    IEnumerator ShowMessage(string message, float delay)
    {
        warning.text = message;
        warning.enabled = true;
        yield return new WaitForSeconds(delay);
        warning.enabled = false; ;
    }

    public void CloseQuestionScreen()
    {
        questionScreen[questionsCount - 1].SetActive(false);
        GameHandler.canMove = true;
    }
}
