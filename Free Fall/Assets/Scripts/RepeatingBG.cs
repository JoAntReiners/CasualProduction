using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    #region Public
    public float speed;
    public float startY;
    public float endY;
    #endregion

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); 

        if(transform.position.y >= endY || transform.position.y <= startY)
        {
            speed *= -1;
        }

    }
}
