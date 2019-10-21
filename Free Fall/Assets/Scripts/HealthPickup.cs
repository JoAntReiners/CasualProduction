using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
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
            Destroy(gameObject);
        }

    }
}
