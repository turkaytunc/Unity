using UnityEngine;

public class PaddleMovement : MonoBehaviour
{

    void Update()
    {
        float currentMousePosition = Input.mousePosition.x / Screen.width * 16;
        Debug.Log(currentMousePosition);
        Vector2 paddlePosition = new Vector2(currentMousePosition, transform.position.y);

        transform.position = paddlePosition;
    }
}
