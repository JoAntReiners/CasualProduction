using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    #region Public
    public ParticleSystem sys;
    #endregion

    #region Private
    private Transform trans;
    #endregion

    private void Update()
    {
        trans = gameObject.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
        Destroy(Instantiate(sys, trans), 1.75f);
        GetComponent<SpriteRenderer>().sprite = null;
        GetComponent<CircleCollider2D>().enabled = false;
        Destroy(gameObject, 2f);
    }
}
