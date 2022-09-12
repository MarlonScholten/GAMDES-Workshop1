using System;
using System.Linq;
using UnityEngine;
using static UnityEngine.Random;

public class ShootBehaviour : MonoBehaviour
{
    public Rigidbody projectile;
    [Range(5f, 100f)]
    public float speed;
    public float torqueForce;
    
    void OnFire()
    {
        var clone = Instantiate(projectile, transform.position, transform.rotation);
        var randomTorque = RandomTorqueVector();

        clone.velocity = transform.TransformDirection(Vector3.forward * speed);
        clone.AddTorque(randomTorque * torqueForce);
    }

    private Vector3 RandomTorqueVector()
    {
        int[] numbers = { -1, 0, 1 };

        Shuffle(numbers);
        Debug.Log(new Vector3(numbers[0], numbers[1], numbers[2]));
        return new Vector3(numbers[0], numbers[1], numbers[2]);
    }
    
    private void Shuffle(int[] numbers)
    {
        for (int t = 0; t < numbers.Length; t++ )
        {
            int tmp = numbers[t];
            int r = Range(t, numbers.Length);
            numbers[t] = numbers[r];
            numbers[r] = tmp;
        }
    }
}
