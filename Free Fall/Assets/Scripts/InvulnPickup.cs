using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvulnPickup : MonoBehaviour
{
    #region Public
    public GameObject sys;
    private GameObject playertransform;
    #endregion
    public void Awake()
    {
        playertransform = GameObject.FindWithTag("Player");
    }

    public void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playertransform.transform.position = collision.transform.position;
            collision.GetComponent<PlayerController>().toggleHurt();
            Destroy(Instantiate(sys, playertransform.transform), 5f);
            GetComponent<SpriteRenderer>().sprite = null;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 5f);
        }
    }
}
