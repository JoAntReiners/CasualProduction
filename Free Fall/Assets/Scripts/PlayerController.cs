using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    #region Public
    public float speed;
    //public float xIncrement;
    //public float yIncrement;
    //public float maxHeight;
    //public float minHeight;
    //public float maxLength;
    //public float minLength;
    public bool vertical;
    public int health = 1;
    public bool canBeHurt = true;
    public Animator camAnim;
    #endregion

    #region Private
    private Vector3 mousePos;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Vector2 targetPos;
    #endregion

    void Start()
    {
        vertical = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        #region Old Code
        /* transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

         if (vertical)
         {
             if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxLength)
             {
                 camAnim.SetTrigger("shake");
                 targetPos = new Vector2(transform.position.x + xIncrement, transform.position.y);
             }
             else if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minLength)
             {
                 camAnim.SetTrigger("shake");
                 targetPos = new Vector2(transform.position.x - xIncrement, transform.position.y);
             }
         }
         else
         {
             if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
             {
                 targetPos = new Vector2(transform.position.x, transform.position.y + yIncrement);
             }
             else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
             {
                 targetPos = new Vector2(transform.position.x, transform.position.y - yIncrement);
             }
         } */
        #endregion
    }

    public void toggleHurt()
    {
        StartCoroutine("toggleInvuln");
    }

    IEnumerator toggleInvuln()
    {
        Debug.Log("Invuln!");
        canBeHurt = false;
        yield return new WaitForSecondsRealtime(5);
        canBeHurt = true;
    }
}
