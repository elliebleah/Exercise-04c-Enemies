using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float moveSpeed = 3f;
    public float detectionRange = 5f;

    private void Update()
    {
        if (playerTransform == null)
        {
            Debug.LogError("Player Transform is not assigned!");
            return;
        }

        // Calculate the distance between the object and the player
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

        // Check if the player is within the detection range
        if (distanceToPlayer <= detectionRange)
        {
            // Move towards the player
            Vector3 directionToPlayer = (playerTransform.position - transform.position).normalized;
            transform.position += directionToPlayer * moveSpeed * Time.deltaTime;
        }
    }
}
