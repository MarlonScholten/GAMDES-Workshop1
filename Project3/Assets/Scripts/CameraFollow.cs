using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform PlayerPosition;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - PlayerPosition.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = PlayerPosition.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPosition, 0.5f);
    }
}
