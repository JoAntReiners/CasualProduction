using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    #region Public
    public int damage = 1;
    public bool up;
    public bool left;
    public bool right;
    public bool down;
    public int speed;
    public AudioClip hitSound;
    public GameObject sys;
    #endregion

    #region Private
    private AudioSource source;
    private Transform trans;
    #endregion

    private void Start()
    {
        source = GameObject.FindGameObjectWithTag("GameController").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (up)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else if (left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (down)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        trans = gameObject.transform;
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
                source.PlayOneShot(hitSound);
                temp.camAnim.SetTrigger("shake");
            }
            else
            {
                Debug.Log("Player hit but is invuln");
            }
            Destroy(Instantiate(sys, trans), 1.75f);
            GetComponent<SpriteRenderer>().sprite = null;
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(gameObject, 2f);
        }
    }

    private void OnDestroy()
    {
        
    }
}
