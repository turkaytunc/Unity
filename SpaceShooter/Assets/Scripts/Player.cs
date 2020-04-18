using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        moveSpeed = 10f;
    }
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float xPos = transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.position = new Vector2(xPos, transform.position.y);
    }
}
