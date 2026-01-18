using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private float speed = 10f;

    void Update()
    {
        HandleInput();
        MovePlayer();
    }

    void HandleInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            targetPosition = Camera.main.ScreenToWorldPoint(mousePos);
            targetPosition.x = Mathf.Clamp(targetPosition.x, -2.3f, 2.3f);
            targetPosition.y = Mathf.Clamp(targetPosition.y, -4.5f, 4.5f);
        }
    }

    void MovePlayer()
    {
        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            speed * Time.deltaTime
        );
    }
}
