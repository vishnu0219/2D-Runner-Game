using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    Animator anim;
    bool check;
    bool gameOver = false;
    [SerializeField]
    float jumpforce=6;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            if (check)
            {
                jump();
            }
        }
    }
    void jump()
    {
        check = false;
        rb.velocity = Vector2.up * jumpforce;
        anim.SetTrigger("jump");
        GameManager.instance.Incrementscore();
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            check = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="obstacles")
        {
            Destroy(collision.gameObject);
            anim.Play("death");
            GameManager.instance.GameOver();
            gameOver = true;
        }
    }
}
