using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoatScript : MonoBehaviour
{
    private void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    public void Visible()
    {
        Debug.Log("invoked this");
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
