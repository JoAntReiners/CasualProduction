using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Public
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public SpriteRenderer bg;
    public Sprite[] backgrounds;
    #endregion

    #region Private
    private float score;
    private PlayerController player;
    #endregion

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        score += (Time.deltaTime);
        scoreText.text = "Score: " + score.ToString("#.##");

        if(score >= 60 && score < 120)
        { 
            bg.sprite = backgrounds[1];
        }
        else if (score >= 120)
        {
            bg.sprite = backgrounds[2];
        }

        healthText.text = "Health: " + player.health;

        if(player.health == 0)
        {
            PlayerPrefs.SetFloat("Score", score);
            if(score > PlayerPrefs.GetFloat("HighScore"))
            {
                PlayerPrefs.SetFloat("HighScore", score);
            }
            SceneManager.LoadScene(2);
        }
    }
}
