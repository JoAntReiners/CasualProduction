using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    #region Public
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    #endregion

    private void Start()
    {
        float score = PlayerPrefs.GetFloat("Score");
        float highScore = PlayerPrefs.GetFloat("HighScore");
        scoreText.text = "Score: " + score.ToString("#.##");
        highScoreText.text = "High Score: " + highScore.ToString("#.##");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
}
