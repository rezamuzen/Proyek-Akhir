using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "book")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "book")
        {
            FindObjectOfType<GameManager>().EndGame();
        }  
         if(collision.collider.tag == "Worm")
        {
            FindObjectOfType<GameManager>().LoseGame();
        }  
    }
    
}
