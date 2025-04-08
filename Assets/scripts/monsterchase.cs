using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monsterchase : MonoBehaviour
{
    public Rigidbody monsRigid;
    public Transform monsTrans, playTrans;
    public int monSpeed;

    public GameObject jumpscareUI;     // Assign your jumpscare image here
    public AudioSource audioSource;    // Assign the scream audio source here
    private bool hasTriggered = false; // Prevents repeated triggers

    void FixedUpdate()
    {
        if (!hasTriggered)
        {
            // Use velocity, not linearVelocity (which doesn't exist)
            monsRigid.linearVelocity = transform.forward * monSpeed * Time.deltaTime;
        }
    }

    void Update()
    {
        if (!hasTriggered)
        {
            monsTrans.LookAt(playTrans);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            monsRigid.linearVelocity = Vector3.zero; // Stop monster movement
            StartCoroutine(TriggerJumpscare());
        }
    }

    IEnumerator TriggerJumpscare()
    {
        if (jumpscareUI != null)
            jumpscareUI.SetActive(true); // Show jumpscare image

        if (audioSource != null)
            audioSource.Play(); // Play scream sound

        yield return new WaitForSeconds(2f); // Wait 2 seconds

        SceneManager.LoadScene("menu"); // Load the "menu" scene
    }
}
