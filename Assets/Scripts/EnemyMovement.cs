using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float moveSpeed = 3f;

    private Transform targetPoint;

    private void Start()
    {
        // Set the initial target point to pointA
        targetPoint = pointA;
    }

    private void Update()
    {
        // Calculate the distance between the enemy and the target point
        float distanceToTarget = Vector3.Distance(transform.position, targetPoint.position);

        // If the enemy is close to the target point, switch to the other point
        if (distanceToTarget <= 0.1f)
        {
            SwitchTarget();
        }

        // Move towards the target point
        Vector3 moveDirection = (targetPoint.position - transform.position).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    private void SwitchTarget()
    {
        // If the current target is pointA, switch to pointB; otherwise, switch to pointA
        if (targetPoint == pointA)
        {
            targetPoint = pointB;
        }
        else
        {
            targetPoint = pointA;
        }
    }
}
