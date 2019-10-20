using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    #region Public
    public GameController controller;
    public ObstacleHolder[] obstacle;
    #endregion

    #region Private
    private int currentPos;
    #endregion

    void Start()
    {
        currentPos = controller.currentPosition;
        int rand = Random.Range(0, obstacle[currentPos].obstacles.Length);
        Instantiate(obstacle[currentPos].obstacles[rand], transform.position, Quaternion.identity);
    }
}
