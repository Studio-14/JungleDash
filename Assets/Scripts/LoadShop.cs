﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadShop : MonoBehaviour {


    private LevelManager levelManager;
    private bool IsOverDoor;
    public bool Shop1, Shop2, Shop3;
    public static Vector3 LocationToRespawn;
    private Player player;


    // Use this for initialization
    void Start()
    {
        //this just automates the process of finding the level manager so you dont have to Manuel drag it in
        levelManager = FindObjectOfType<LevelManager>();
        player = FindObjectOfType<Player>();
    }
    private void Update()
    {
       
        if(IsOverDoor)
        {
            EnterShop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //when you hit the trigger on the door, then it sets IsOverDoor true
        IsOverDoor = true;


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        IsOverDoor = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
        //prevents from loading when you walk away from door 
    {
        IsOverDoor = false;
    }

    private void EnterShop()
    {
        //when you press spacebar inside of the trigger for the door then it will throw you into the level
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LocationToRespawn = player.transform.position;
            if (Shop1)
            {
                levelManager.LoadLevel("Shop 1");
            }
            if (Shop2)
            {
                levelManager.LoadLevel("Shop 2");
            }
            if (Shop3)
            {
                levelManager.LoadLevel("Shop 3");
            }

        }
    }
}
