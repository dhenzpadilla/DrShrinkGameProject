using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverScreen : MonoBehaviour
{
    public GameObject GameOverUI;
    private void Start()
    {
        GameOverUI.SetActive(false);
    }
    private void Update()
    {
        GameObject player = GameObject.Find("Player");
        if (player == null)
        {
            GameOverUI.SetActive(true);
        }
    }

    /*void GameOver()
    {   
        if (isGameOver == false)
        {
            isGameOver = true;
            Debug.Log("Gameover pop up");
        }
    }*/
}
