using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    #region Public
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    #endregion

    #region Private
    private string gameID = "3340866";
    [SerializeField] private bool testMode = true;
    private bool isShown = false;
    #endregion

    private void Start()
    {
        Advertisement.Initialize(gameID, testMode);
        float score = PlayerPrefs.GetFloat("Score");
        float highScore = PlayerPrefs.GetFloat("HighScore");
        scoreText.text = score.ToString("#.##");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        if (Advertisement.IsReady() && !isShown)
        {
            isShown = true;
            Advertisement.Show();
        }
    }
}
