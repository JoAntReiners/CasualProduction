using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    #region Public
    public float speed;
    public float startY;
    public float endY;
    public float startX;
    public float endX;
    #endregion

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); 

        if(transform.position.y >= endY)
        {
            Vector2 pos = new Vector2(transform.position.x, startY);
            transform.position = pos;
        }

    }
}
