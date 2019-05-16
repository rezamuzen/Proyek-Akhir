using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBook : MonoBehaviour
   
{
    public AudioSource collectSound;
    void OnTriggerEnter2D(Collider2D collision)
    {
        collectSound.Play();
        ScoringSystem.theScore += 50;
    }
}
