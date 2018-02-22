using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

    public static string currentScene;

    public void LoadLevelOne()
    {
        currentScene = "Level1";
        SceneManager.LoadScene(currentScene);
    }

    public void LoadLevelTwo()
    {
        currentScene = "Level2";
        SceneManager.LoadScene(currentScene);
    }
}
