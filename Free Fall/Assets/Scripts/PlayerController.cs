using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    #region Public
    public float speed;
    public float xIncrement;
    public float yIncrement;
    public float maxHeight;
    public float minHeight;
    public float maxLength;
    public float minLength;
    public bool vertical;
    public int health = 1;
    public bool canBeHurt = true;
    public Animator camAnim;
    #endregion

    #region Private
    private Vector2 targetPos;
    #endregion

    void Start()
    {
        vertical = true;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

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
        }
    }

    public void toggleHurt()
    {
        StartCoroutine("toggleInvuln()");
    }

    IEnumerable toggleInvuln()
    {
        canBeHurt = false;
        yield return new WaitForSecondsRealtime(5);
        canBeHurt = true;
    }
}
