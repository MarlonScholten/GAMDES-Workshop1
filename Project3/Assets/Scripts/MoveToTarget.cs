using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public GameObject target;
    public bool TargetReached { get; set; }
    public bool revived;
    public Material reviveMaterial;
    private NavMeshAgent _navMeshAgent;

    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (!revived)
        {
            if (!TargetReached)
            {
                MoveTo(target.transform.position);
            }
            else
            {
                _navMeshAgent.ResetPath();
            }
        }
        else
        {
            Revive();
        }
    }

    void MoveTo(Vector3 target)
    {
        _navMeshAgent.SetDestination(target);
    }

    private void Revive()
    {
        revived = true;
        GetComponent<Renderer>().material = reviveMaterial;
        _navMeshAgent.ResetPath();
    }
}
