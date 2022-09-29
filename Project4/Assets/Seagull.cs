using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Seagull : MonoBehaviour
{
    private NavMeshAgent seagull;

    public Transform player;
    public Rigidbody seagullRb;

    public bool run;

    // Start is called before the first frame update
    void Start()
    {
        seagull = GetComponent<NavMeshAgent>();
        seagullRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > 10)
        {
            Vector3 lookDirection = (player.transform.position - transform.position);
            seagull.SetDestination(player.position);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            seagullRb.AddForce(-transform.forward * 100f);
            seagull.ResetPath();
           // Vector3 lookDirection = (transform.position - player.transform.position);
        }
    }
}
