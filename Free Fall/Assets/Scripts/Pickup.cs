using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    #region Public
    public bool up;
    public bool left;
    public bool right;
    public bool down;
    public int speed;
    #endregion

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
    }

    private void OnDestroy()
    {

    }
}
