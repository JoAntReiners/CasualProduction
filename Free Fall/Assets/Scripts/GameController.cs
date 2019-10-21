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
    public Image healthDisplay;
    public Sprite[] healthImages;
    public SpriteRenderer bg;
    public Sprite[] backgrounds;
    public int currentPosition;
    #endregion

    #region Private
    private float score;
    private PlayerController player;
    private int currentDir;
    private float timer;
    #endregion

    void Start()
    {
        currentPosition = 0;
        currentDir = 1;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        score += (Time.deltaTime);
        timer += Time.deltaTime;
        scoreText.text = score.ToString("#.##");

        if(timer >= 15)
        {
            timer = 0;
            currentPosition += currentDir;

            if(currentPosition == backgrounds.Length-1)
            {
                currentDir *= -1;
            }
            else if(currentPosition == 0)
            {
                currentDir *= -1;
            }

            bg.sprite = backgrounds[currentPosition];
        }
        
        if(player.health == 3)
        {
            healthDisplay.sprite = healthImages[0];
        }
        else if(player.health == 2)
        {
            healthDisplay.sprite = healthImages[1];
        }
        else if(player.health == 1)
        {
            healthDisplay.sprite = healthImages[2];
        }

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
