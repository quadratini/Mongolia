using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public BirdScript bird;

    void Start()
    {
       bird = bird.GetComponent<BirdScript>();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (bird.birdIsAlive) 
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
