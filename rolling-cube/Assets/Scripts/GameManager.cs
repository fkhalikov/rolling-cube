using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    

    bool gameHasEnded = false;

    public Text messageText;
    public GameObject completeLevelUI;

    public float restartDelay = 1f;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            messageText.text = "LET'S TRY AGAIN";
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
