using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; 

        mousePos.x = Mathf.Clamp(mousePos.x, -2.3f, 2.3f);
        mousePos.y = Mathf.Clamp(mousePos.y, -4.5f, 4.5f);

        transform.position = Vector3.Lerp(
            transform.position,
            mousePos,
            speed * Time.deltaTime
        );
    }
}