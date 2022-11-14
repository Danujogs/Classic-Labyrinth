using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource AudioSource;
    public GameObject objectMusic;
    public Slider volumeSlider;
    private float MusicVolume = 10f;

    void Start()
    {
        objectMusic = GameObject.FindWithTag("BGM");
        AudioSource = objectMusic.GetComponent<AudioSource>();

        MusicVolume = PlayerPrefs.GetFloat("Volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
    }

    void Update()
    {
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("Volume", MusicVolume);
    }

    public void UpdateVolume(float volume)
    {
        MusicVolume = volume;
    }
}
