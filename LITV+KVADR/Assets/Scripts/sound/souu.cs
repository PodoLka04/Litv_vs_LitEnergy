using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class souu : MonoBehaviour
{
    public AudioSource bg_sound;
    public AudioSource MainTapSound;
    public AudioSource NotMainTapSound;

    // Start is called before the first frame update
    void Start()
    {
        bg_sound.Play();
    }

    public void SoundClickMain()
    {
        MainTapSound.Play();
    }


    public void SoundClickNotMain()
    {
        NotMainTapSound.Play();
    }
}
