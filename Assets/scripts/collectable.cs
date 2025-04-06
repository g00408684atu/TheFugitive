using UnityEngine;
using System.Collections;

public class collectable : MonoBehaviour
{
    public float speedBoostAmount = 2f;
    public float boostDuration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StarterAssets.FirstPersonController controller = other.GetComponent<StarterAssets.FirstPersonController>();

            if (controller != null)
            {
                StartCoroutine(ApplySpeedBoost(controller));
                Destroy(gameObject); // Destroy medkit after pickup
            }
        }
    }

    private IEnumerator ApplySpeedBoost(StarterAssets.FirstPersonController player)
    {
        // Store original speeds
        float originalMoveSpeed = player.MoveSpeed;
        float originalSprintSpeed = player.SprintSpeed;

        // Apply boost
        player.MoveSpeed += speedBoostAmount;
        player.SprintSpeed += speedBoostAmount;

        yield return new WaitForSeconds(boostDuration);

        // Revert speeds
        player.MoveSpeed = originalMoveSpeed;
        player.SprintSpeed = originalSprintSpeed;
    }
}
