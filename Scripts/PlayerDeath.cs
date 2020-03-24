﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Die"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
