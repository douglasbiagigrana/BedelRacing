using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 5f;

    public GameObject completeLevelUI;
    public GameObject gameOverLevelUI;

    public void CompleteLevel()
    {
        if(gameHasEnded == false)
        {
            completeLevelUI.SetActive(true);
            gameHasEnded = true;
            Invoke("End", restartDelay + 5);
        }
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameOverLevelUI.SetActive(true);
            gameHasEnded = true;
            Invoke("Restart", restartDelay + 2);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene("Prototype 1");

    }

    void End()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
