using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private PaddleMovement paddle;
    [SerializeField] private Vector2 paddleToBallVector;
    [SerializeField] private bool isGameStarted;
    [SerializeField] private float horizontalVelocity;
    [SerializeField] private float verticalVelocity;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        SetBallPosition();
    }

    // Update is called once per frame
    void Update()
    {

        if (!isGameStarted)
        {
            SetBallPosition();
            LaunchBall();
        }
    }

    private void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isGameStarted = true;
            rb2d.velocity = new Vector2(horizontalVelocity, verticalVelocity);
        }
    }

    private void SetBallPosition()
    {
        paddleToBallVector = (Vector2)paddle.transform.position + Vector2.up;
        transform.position = paddleToBallVector;
    }
}
