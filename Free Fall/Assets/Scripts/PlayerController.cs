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
        #region Mouse Movement
        /* Mouse Movement
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
        */
        #endregion

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            mousePos = Camera.main.ScreenToWorldPoint(touch.position);
            direction = (mousePos - transform.position).normalized;
            rb.velocity = new Vector2(direction.x * speed * Time.deltaTime, direction.y * speed * Time.deltaTime);

            if(touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
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
