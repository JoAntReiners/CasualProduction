using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    #region Public
    public float lifeTime;
    #endregion

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
