using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel: MonoBehaviour
{
    public int iLevelToLoad;
    public string sLevelToLoad;

    public bool useIntToLoadLevel = false;
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
        ScoreManager.scoreValue = 10;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void SceneLevel()
    {
        if (useIntToLoadLevel)
        {           
            SceneManager.LoadScene(iLevelToLoad);
        }
        else
        {
            SceneManager.LoadScene(sLevelToLoad);
        }
    }

}
