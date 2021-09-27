using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue = 0;
    public int nextScore;
    Text score;

    public GameObject portal;

    void Start()
    {
        score = GetComponent<Text> ();
        portal.SetActive(false);
    }

    void Update()
    {
        
        score.text = scoreValue + " Kills" ;
        if (scoreValue == 10)
        {
            scoreValue += nextScore;
            portal.SetActive(true);
            //GameObject Canvas = GameObject.Find("Canvas");
            //Canvas.GetComponent<LoadLevel>().SceneLevel();
        }
    }
}
