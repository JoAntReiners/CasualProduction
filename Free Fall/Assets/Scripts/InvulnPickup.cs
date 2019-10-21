using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvulnPickup : MonoBehaviour
{
    #region Public
    public ParticleSystem sys;
    #endregion

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().toggleHurt();
            Destroy(gameObject);
        }
    }
}
