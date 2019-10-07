using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    #region Public
    public GameObject obstacle;
    #endregion

    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
