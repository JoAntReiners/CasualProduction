using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Public
    public DirectionHolder[] obstaclePatterns;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    #endregion

    #region Private
    private float timeBetweenSpawn;
    private int currentLevel;
    private GameController controller;
    #endregion

    private void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    void Update()
    {
        currentLevel = controller.currentLevel;
        if(currentLevel >= 5)
        {
            currentLevel = 4;
        }
        if(timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns[currentLevel].Directions.Length);
            Instantiate(obstaclePatterns[currentLevel].Directions[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;

            if(startTimeBetweenSpawn > minTime)
            {
                startTimeBetweenSpawn -= decreaseTime;
            }

        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
