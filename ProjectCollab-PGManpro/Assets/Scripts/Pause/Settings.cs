using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private AudioMixer musicMixer;
    [SerializeField] private AudioMixer sfxMixer;

    // Start is called before the first frame update
    void Start()
    {
        musicSlider.onValueChanged.AddListener(ChangeMusicVolume);
        sfxSlider.onValueChanged.AddListener(ChangeSFXVolume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // public void ChangeBrightness(float value)
    // {
    //     Screen.brightness = value;
    //     Debug.Log(value);
    // }
    
    public void ChangeMusicVolume(float value)
    {
        musicMixer.SetFloat("musicVolume", value);
        Debug.Log(value);

    }

    public void ChangeSFXVolume(float value)
    {
        sfxMixer.SetFloat("sfxVolume", value);
        Debug.Log(value);
    }
}
