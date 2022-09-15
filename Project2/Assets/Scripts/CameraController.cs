using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float verticalRotation;
    public Vector3 cameraPosition;
    private Transform _target;

    private void Awake()
    {
        _target = player.transform;
    }
    private void Update()
    {
        Look();
    }

    private void Look()
    {
        transform.position = _target.TransformPoint(cameraPosition);
        transform.LookAt(_target.position + new Vector3(0f, verticalRotation, 0f));
    }
}