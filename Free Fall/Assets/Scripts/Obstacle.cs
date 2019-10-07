using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    #region Public
    public int damage = 1;
    public int speed;
    #endregion

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerController temp = collision.GetComponent<PlayerController>();
            if(temp.canBeHurt)
            {
                temp.health -= damage;
                Debug.Log("Player hit, health at " + temp.health);
            }
            else
            {
                Debug.Log("Player hit but is invuln");
            }
            Destroy(gameObject);
        }
    }
}
