using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePlate : MonoBehaviour
{
    public AudioSource aud;
    private bool pressed = false;
    public UnityEvent boat = new UnityEvent();

    private void Start()
    {
        Debug.Log("yes");
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Pressure plate trigger");
        if (!pressed) {
            if (collision.transform.CompareTag("Player")) {
                Debug.Log("Pressure plate trigger");
                transform.position += new Vector3(0, -0.1f, 0);
                aud.Play();
                pressed = true;
                boat.Invoke();
            }
        }
    }
}
