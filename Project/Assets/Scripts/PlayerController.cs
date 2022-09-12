using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Range(0.5f, 10)]
    public float movementSpeed;
    [Range(2, 20f)]
    public float turnSpeed;
    private Rigidbody _rb;
    private float _movementX;
    private float _movementY;
    private float _rotationY;

    private void Awake()
    {
        if(gameObject.GetComponent<Rigidbody>() == null)
            gameObject.AddComponent<Rigidbody>();

        _rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if(_movementX != 0 || _movementY != 0)
            Move(_movementX, _movementY);

        if (_rotationY != 0)
            Look(_rotationY);
    }

    private void OnMove(InputValue inputValue)
    {
        var movement = inputValue.Get<Vector2>();
        
        _movementX = movement.x;
        _movementY = movement.y;
    }

    private void OnLook(InputValue inputValue)
    {
        var rotation = inputValue.Get<Vector2>();

        _rotationY = rotation.x;
    }

    private void Move(float x, float z)
    {
        Vector3 newPosition = _rb.position + transform.TransformDirection(new Vector3(x, 0f, z)) * (movementSpeed * Time.deltaTime);
        _rb.MovePosition (newPosition);
    }

    private void Look(float rotationY)
    {
        var rotation = new Vector3(0f, rotationY, 0f);
        
        Quaternion deltaRotation = Quaternion.Euler(rotation * (turnSpeed * Time.fixedDeltaTime));
        _rb.MoveRotation(_rb.rotation * deltaRotation);
    }
}
