using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 15f; 

    void Update()
    {
        transform.Translate(Vector3.up * flySpeed * Time.deltaTime);

        if (transform.position.y > 6f) 
        {
            Destroy(gameObject);
        }
    }
}