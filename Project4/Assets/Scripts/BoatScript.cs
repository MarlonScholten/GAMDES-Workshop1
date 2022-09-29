using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoatScript : MonoBehaviour
{
    public void Visible()
    {
        Debug.Log("invoked this");
        transform.GetChild(1).gameObject.SetActive(true);
    }
}
