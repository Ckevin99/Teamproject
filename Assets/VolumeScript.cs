using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class VolumeController : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider volumeSlider;
    public AudioSource backgroundMusic;

    void Start()
    {
        backgroundMusic.volume = volumeSlider.value;

        volumeSlider.onValueChanged.AddListener(OnVolumeChange);
    }

    // Update is called once per frame
    void OnVolumeChange(float value)
    {
        backgroundMusic.volume = value;
    }
}
