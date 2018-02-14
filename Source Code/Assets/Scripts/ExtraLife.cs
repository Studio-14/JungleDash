﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour {

    //If the player has less than 3 lives, the Extra Life adds a life.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            if (PlayerPrefsManager.GetLives() < 3)
            {
                PlayerPrefsManager.AddLives(1);
            }
            else
            {
                PlayerPrefsManager.SetHealth(100);
            }

            Destroy(gameObject);
        }
    }
}
