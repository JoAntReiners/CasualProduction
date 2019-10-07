using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Public
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
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
        score += (9.81f * Time.deltaTime);
        scoreText.text = "Score: " + score.ToString("#.##");

        healthText.text = "Health: " + player.health;

        if(player.health == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
