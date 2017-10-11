﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb2d;
    [SerializeField]
    private float speed = 10;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float horizontal = Input.GetAxis("Horizontal");

        HandleMovement(horizontal);
	}

    private void HandleMovement(float horizontal)
    {
        rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);
    }
}
