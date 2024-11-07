using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    #region VARIABLES
    [Header("MIXER & SOURCES")]
    [Space(5)]
    public AudioSource BGMSource;
    public AudioSource SFXSource;
    AudioMixer mixer;

    [Header("SLIDERS")]
    [Space(5)]
    public Slider masterSlider;

    [Header("SFXs")]
    [Space(5)]
    public AudioClip grabSound;
    public AudioClip releaseSound;
    public AudioClip payCompletedSound;
    public AudioClip payFailedSound;
    #endregion

    private void Update()
    {
        mixer.SetFloat("masterVolume", masterSlider.minValue)
    }

    public void PlaySFX(AudioClip clipToPlay)
    {
        SFXSource.clip = clipToPlay;
    }
}
