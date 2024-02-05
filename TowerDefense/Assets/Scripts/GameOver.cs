using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public int gameOver = 1;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag($"Enemy"))
        {
            gameOver--;
            Debug.Log(gameOver);
        }
    }
}
