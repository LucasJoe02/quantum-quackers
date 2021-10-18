using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip Quack;
    public AudioClip Switch;
    public AudioClip Phase;

    public static SFX sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInstance = this;
        DontDestroyOnLoad(this);
    }

    public void sfx_Quack()
    {
        Audio.PlayOneShot(Quack);
    }

    public void sfx_Switch()
    {
        Audio.PlayOneShot(Switch);
    }

    public void sfx_Phase()
    {
        Audio.PlayOneShot(Phase);
    }
}
