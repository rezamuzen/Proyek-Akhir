using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene("victory");
    }
    public void LoseGame()
    {
        SceneManager.LoadScene("gameover");
    }
}
