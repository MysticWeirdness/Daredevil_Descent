using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOldEnemies : MonoBehaviour
{
    private float Offset = 2;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Update()
    {
        if (transform.position.y > playerTransform.position.y + Offset)
        {
            GenerateEnemy();
        }
    }
    private void GenerateEnemy()
    {
        float randomX = Random.Range(-5, 5);
        Vector3 newPos = new Vector3(randomX, playerTransform.position.y - 8, 0);
        Instantiate(GetComponent<Rigidbody2D>(), newPos, Quaternion.identity);
    }
}
