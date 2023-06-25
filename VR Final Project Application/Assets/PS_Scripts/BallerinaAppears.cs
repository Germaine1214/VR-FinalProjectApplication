using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallerinaAppears : MonoBehaviour
{
    public Light lightSource;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public BallerinaRotate Rotation;

    private void Start()
    {
        StartCoroutine(ActivateLightAndAudio());
    }

    private IEnumerator ActivateLightAndAudio()
    {
        yield return new WaitForSeconds(3f); // Wait for 3 seconds

        lightSource.enabled = true; // Activate the light
        Debug.Log("Light succesfully enabled");
        audioSource.clip = audioClip;
        audioSource.Play(); // Play the audio clip

        yield return new WaitForSeconds(1f); // Wait for 1 second after light activation
        Rotation.StartRotating(); // Start rotating the object
    }
}
