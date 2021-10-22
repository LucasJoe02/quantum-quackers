using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    public AudioSource Audio;
    public AudioSource Audio_Walking;

    [Header("SFX Clips")]
    public AudioClip Quack;
    public AudioClip Switch;
    public AudioClip Jump;
    public AudioClip Bread;
    public AudioClip Grape;
    public AudioClip Death;
    public AudioClip Click;

    private string death;

    private void Awake()
    {
        sfx_Click();
    }

    public void sfx_Quack()
    {
        Audio.PlayOneShot(Quack);
    }

    public void sfx_Bread()
    {
        Audio.PlayOneShot(Bread, 0.6f);
    }

    public void sfx_Click()
    {
        Audio.PlayOneShot(Click, 1f);
    }

    public void sfx_Switch()
    {
        Audio.PlayOneShot(Switch, 0.15f);
    }

    public void sfx_Jump()
    {
        Audio.PlayOneShot(Jump, 0.1f);
    }

    public void sfx_Grape()
    {
        Audio.PlayOneShot(Grape, 0.15f);
    }

    public void sfx_Death_Grape()
    {
        Audio.clip = Death;
        Audio.PlayDelayed(0.55f);
    }

    public void sfx_Death_Barrier()
    {
        Audio.clip = Death;
        Audio.Play();
    }

    public void sfx_Walking()
    {
        if (Audio_Walking.isPlaying == false)
        {
            Audio_Walking.Play();
        }
    }
}
