using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Rigidbody2D enemyRb;
    void Start()
    {
        Instantiate(enemyRb, new Vector3(Random.Range(-5, 5), -8, 0), Quaternion.identity);
    }
}
