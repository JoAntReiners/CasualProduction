using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
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
        if(collision.CompareTag("Player"))
        {
            int temp = collision.GetComponent<PlayerController>().health;
            if(temp == 3)
            {

            }
            else
            {
                collision.GetComponent<PlayerController>().health++;
            }
            Debug.Log(collision.GetComponent<PlayerController>().health);
            Destroy(Instantiate(sys, trans), 1.75f);
            GetComponent<SpriteRenderer>().sprite = null;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 2f);
        }

    }
}
