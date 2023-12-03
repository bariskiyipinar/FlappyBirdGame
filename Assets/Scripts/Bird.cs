using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isdead;
    public float velocity= 1f;
    public  Rigidbody2D rb2D;

    public GameManager managergame;

    void Update()
    {
        //Týklamayý Al
        if(Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="ScoreArea")
        {
            managergame.Updatescore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeathArea")
        {
            isdead = true;
            Time.timeScale = 0;
        }
    }
}
