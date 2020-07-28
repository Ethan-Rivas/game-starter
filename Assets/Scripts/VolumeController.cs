using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    private AudioSource AudioSrc;
    private float AudioVolume = 0.5f;
    private int wholeNumber = 10;

    public AudioClip clip;

    void Start()
    {
        AudioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        AudioSrc.volume = AudioVolume;
    }

    // Because we're using whole numbers on sliders divide by N.
    public void SetVolume(float vol)
    {
        AudioVolume = vol / wholeNumber;

        if(AudioSrc && clip)
        {
            AudioSrc.PlayOneShot(clip, AudioVolume);
        }
    }
}