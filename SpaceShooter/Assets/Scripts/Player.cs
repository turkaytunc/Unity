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
        float xPos = transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        float yPos = transform.position.y + Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;

        transform.position = new Vector2(Mathf.Clamp(xPos, -5.4f, 5.4f), Mathf.Clamp(yPos, -9.5f, 9.5f));
    }
}
