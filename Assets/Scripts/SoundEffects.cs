using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Astronaut"))
        {
            source.PlayOneShot(clip);
        }
    }
}
