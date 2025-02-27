using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public int delay;

    void Start()
    {
        audioSource.PlayDelayed(delay);
    }
}
