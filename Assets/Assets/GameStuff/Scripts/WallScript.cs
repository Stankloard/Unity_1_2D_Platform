﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    private Collider2D collider;
    // Start is called before the first frame update
    void Awake()
    {
        collider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collider.isTrigger = false;
        }
        else
        {
            collider.isTrigger = true;
        }
    }
}
