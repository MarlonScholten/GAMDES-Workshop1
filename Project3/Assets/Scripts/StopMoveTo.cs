using UnityEngine;

public class StopMoveTo : MonoBehaviour
{
    private MoveToTarget moveToTarget;

    void Awake()
    {
        moveToTarget = GetComponentInParent<MoveToTarget>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            moveToTarget.TargetReached = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            moveToTarget.TargetReached = false;
        }
    }
}
