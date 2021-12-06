using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseMover : MonoBehaviour
{
    public float speed;

    public Vector2 moveVector;

    public float timeBeforeDestroy;
    void Start()
    {
        Destroy(gameObject, timeBeforeDestroy);
    }

    
    void Update()
    {
        transform.Translate(moveVector * speed * Time.deltaTime);
    }
}
