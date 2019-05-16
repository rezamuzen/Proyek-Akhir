﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Explosion : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "wall" || col.gameObject.tag == "Worm")
        {
           Destroy(col.gameObject);
        } else if (col.gameObject.tag == "Player")
        {
           Destroy(col.gameObject);
            SceneManager.LoadScene("gameover");
        }
    }
}
