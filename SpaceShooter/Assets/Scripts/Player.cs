using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject laserPrefab;

    private float moveSpeed;
    private float laserOffset;

    private float minPlayerXPos;
    private float maxPlayerXPos;
    private float minPlayerYPos;
    private float maxPlayerYPos;

    private float playerPositionOffsetY = .5f;
    private float playerPositionOffsetX = .25f;

    private void Start()
    {
        moveSpeed = 7f;
        laserOffset = .5f;
        PlayerMovementBoundaries();
    }


    void Update()
    {
        CalculatePlayerShipMovement();
        ShootLaser();
    }

    private void ShootLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 laserPosition = new Vector3(transform.position.x, transform.position.y + laserOffset, transform.position.z);

            Instantiate(laserPrefab, laserPosition, Quaternion.identity);
        }
    }

    private void PlayerMovementBoundaries()
    {
        Camera mainCamera = Camera.main;

        minPlayerXPos = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        maxPlayerXPos = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;

        minPlayerYPos = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        maxPlayerYPos = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
    }

    private void CalculatePlayerShipMovement()
    {
        Vector2 playerPosition = CalculatePlayerInputValues();

        float newXPos = Mathf.Clamp(playerPosition.x, minPlayerXPos + playerPositionOffsetX, maxPlayerXPos - playerPositionOffsetX);
        float newYPos = Mathf.Clamp(playerPosition.y, minPlayerYPos + playerPositionOffsetY, maxPlayerYPos - playerPositionOffsetY);

        transform.position = new Vector2(newXPos, newYPos);
    }

    private Vector2 CalculatePlayerInputValues()
    {
        float xPos, yPos;
        xPos = transform.position.x + Input.GetAxisRaw("Horizontal") * Time.deltaTime * moveSpeed;
        yPos = transform.position.y + Input.GetAxisRaw("Vertical") * Time.deltaTime * moveSpeed;

        return new Vector2(xPos, yPos);
    }
}
