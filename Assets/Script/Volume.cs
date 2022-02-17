using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    private AudioSource audioSource;
    private float musicVolume = 1;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        audioSource.volume = musicVolume;
    }
    public void VolumeSet(float vol)
    {
        musicVolume = vol;
    }
}
