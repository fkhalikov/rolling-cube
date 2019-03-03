using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevelManager : ILevelManager
{
    public void LoadCompleteLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("LevelComplete");
    }

    public void LoadLevel(int level)
    {
        string levelName = "Level";

        if (level <= 9)
        {
            levelName += "0";
        }
    Debug.Log("Loading level "+ $"{levelName}{level}");
        SceneManager.LoadScene($"{levelName}{level}");
    }

    public void LoadRetryAgain(int level)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("RetryAgain");
    }
}
