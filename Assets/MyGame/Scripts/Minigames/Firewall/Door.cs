using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("Level Transition Settings")]
    public GameObject currentLevel;      // Parent GameObject of current level
    public GameObject nextLevel;         // Parent GameObject of next level
    public Transform playerSpawnPoint;   // Where the player should be moved

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Move the player to the new spawn point
            if (playerSpawnPoint != null)
            {
                collision.transform.position = playerSpawnPoint.position;
            }

            // Activate next level
            if (nextLevel != null)
            {
                nextLevel.SetActive(true);
            }

            // Deactivate current level
            if (currentLevel != null)
            {
                currentLevel.SetActive(false);
            }
        }
    }
}
