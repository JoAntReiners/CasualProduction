using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    #region Public
    public GameObject[] obstacle;
    #endregion

    void Start()
    {
        int rand = Random.Range(0, obstacle.Length);
        Instantiate(obstacle[rand], transform.position, Quaternion.identity);
    }
}
