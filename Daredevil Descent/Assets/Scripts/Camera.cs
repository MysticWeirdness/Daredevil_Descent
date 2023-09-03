using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    private float yOffset = -3;
    void Update()
    {
        Vector3 cameraTransform = new Vector3(0, playerTransform.position.y + yOffset, -10);
        transform.position = cameraTransform;
    }
}
