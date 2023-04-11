using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetInteraction : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;

    public void playClip()
    {
        audioSource.PlayOneShot(clip, 0.5f);
    }

}
