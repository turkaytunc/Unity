using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    void Update()
    {
        float currentMousePosition = Input.mousePosition.x / Screen.width * 16;
        Vector2 paddlePosition = new Vector2(Mathf.Clamp(currentMousePosition, 0, 15.35f), transform.position.y);

        transform.position = paddlePosition;
    }
}
