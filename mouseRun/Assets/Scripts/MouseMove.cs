using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public Vector2 moveLeft;
    public Vector2 moveRight;

    public bool isRight;
    public bool isLeft;

    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (isLeft)
        {
            if (transform.position.x > -2.2f)
            {
                transform.Translate(moveLeft * Time.deltaTime * speed);
            }
            
        }

        if (isRight)
        {
            if (transform.position.x < 2.2f)
            {
                transform.Translate(moveRight * Time.deltaTime * speed);
            }

        }
         
    }

    public void TurnLeft(bool isOn)
    {
        isLeft = isOn;

    }

    public void TurnRight(bool isOn)
    {
        isRight = isOn;

    }
}
