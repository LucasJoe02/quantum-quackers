using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public AudioSource Audio;

    public AudioClip Quack;
    public AudioClip Switch;
    public AudioClip Phase;
    public AudioClip Jump;
    public AudioClip Land;

    public static sfx sfxInstance;
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

    private void Update()
    {
        
    }
    public void sfx_Quack()
    {
        Audio.PlayOneShot(Quack);
    }

    public void sfx_Landing()
    {
        Audio.PlayOneShot(Land);
    }
    public void sfx_Switch()
    {
        Audio.PlayOneShot(Switch);
    }

    public void sfx_Jump()
    {
        Audio.PlayOneShot(Jump, 1);
    }
    public void sfx_Phase()
    {
        Audio.PlayOneShot(Phase);
    }
}
