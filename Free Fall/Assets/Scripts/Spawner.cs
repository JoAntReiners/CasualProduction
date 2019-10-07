using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    #region Public
    public GameObject[] obstaclePatterns;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    #endregion

    #region Private
    private float timeBetweenSpawn;
    #endregion

    void Update()
    {
        if(timeBetweenSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
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
