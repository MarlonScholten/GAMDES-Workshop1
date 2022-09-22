using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Camera camera;
    private NavMeshAgent agent;
    public float playerHealth;
    public float reviveCounter;
    // public Transform moveToPosition;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        playerHealth = 100;
        reviveCounter = 0;
    }
    private void Update()
    {
        Debug.Log(reviveCounter);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;
            if (Physics.Raycast(ray, out hitPoint))
            {
                agent.destination = hitPoint.point;
            }
        }
        if (playerHealth <= 0)
        {
            Debug.Log("Game Over!");
            gameObject.SetActive(false);
        }
    }


}