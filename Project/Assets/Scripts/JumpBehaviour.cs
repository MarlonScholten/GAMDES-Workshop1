using UnityEngine;

public class JumpBehaviour : MonoBehaviour
{
    [Range(1f, 10f)]
    public float jumpHeight;
    private Rigidbody _rb;

    private void Awake()
    {
        if(gameObject.GetComponent<Rigidbody>() == null)
            gameObject.AddComponent<Rigidbody>();

        _rb = gameObject.GetComponent<Rigidbody>();
    }
    
    private void OnJump()
    {
        _rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
    }
    
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.9f);
    }
}
