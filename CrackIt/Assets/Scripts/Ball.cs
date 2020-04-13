using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private PaddleMovement paddle;


    [SerializeField] private Vector2 paddleToBallVector;
    void Start()
    {
        SetBallPosition();
    }

    // Update is called once per frame
    void Update()
    {
        SetBallPosition();
    }

    private void SetBallPosition()
    {
        paddleToBallVector = (Vector2)paddle.transform.position + Vector2.up;
        transform.position = paddleToBallVector;
    }
}
