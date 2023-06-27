using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 1f;

    private void Update()
    {
        // Calculate the direction to the target
        Vector3 direction = target.position - transform.position;
        direction.Normalize();

        // Move the object towards the target
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}