using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;    
    public float shootingInterval = 0.2f; 
    public Vector3 bulletOffset = new Vector3(0, 1f, 0); 

    private float _lastBulletTime; 

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - _lastBulletTime > shootingInterval)
            {
                Shoot();
                _lastBulletTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        Vector3 spawnPosition = transform.position + bulletOffset;
        Instantiate(bulletPrefab, spawnPosition, transform.rotation);
    }
}