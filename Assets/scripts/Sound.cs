using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    public void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
