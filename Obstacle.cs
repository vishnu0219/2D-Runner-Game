using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    [SerializeField]
    private float movespeed=0; 
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = Vector2.left * movespeed;
    }
}
