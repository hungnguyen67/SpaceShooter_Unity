using UnityEngine;

public class Stars : MonoBehaviour
{
    public float scrollSpeed = 2.0f;
    public float resetPositionY = 10.0f;
    public float endPositionY = -10.0f;  

    void Update()
    {
        // Move the object downward
        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);

        // If it goes off screen, reset it to the top
        if (transform.position.y <= endPositionY)
        {
            transform.position = new Vector3(transform.position.x, resetPositionY, transform.position.z);
        }
    }
}