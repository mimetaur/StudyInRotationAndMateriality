using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] clips;
    public AudioSource source;

    public void PlaySound()
    {
        AudioClip clip = clips[Random.Range(0, clips.Length)];
        float volume = Random.Range(0.2f, 0.6f);
        source.PlayOneShot(clip, volume);
    }

    public void PlaySound(float volume)
    {
        AudioClip clip = clips[Random.Range(0, clips.Length)];
        source.PlayOneShot(clip, volume);
    }
}