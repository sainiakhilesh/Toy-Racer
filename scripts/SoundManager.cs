using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource carSoundPlayer;
    public AudioSource menuSoundPlayer;

    public void PlayCarSound()
    {
        carSoundPlayer.Play();
    }

    public void PlayMenuSound()
    {
        menuSoundPlayer.Play();
    }
}

