using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamAudio : MonoBehaviour
{
    // Reference to the AudioSource component
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Ensure an AudioSource is attached
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component found on this GameObject. Please attach an AudioSource.");
        }
    }

    // This method is called when the object collides with another object
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the AudioSource exists and is not already playing
        if (audioSource != null && !audioSource.isPlaying)
        {
            // Play the audio
            audioSource.Play();
        }

        // Destroy the GameObject after playing the sound
        Destroy(gameObject, audioSource.clip.length);
    }
}