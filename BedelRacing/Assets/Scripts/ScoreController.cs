using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameManager gameManager;
    public Text scoreText;
    private int score = 10;

    void Start()
    {
        scoreText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            scoreText.text = (--score).ToString();

            if (score == 0)
            {
                gameManager.GameOver();
            }
        };
    }
}
