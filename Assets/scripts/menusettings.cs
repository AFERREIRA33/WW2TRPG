using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class menusettings : MonoBehaviour
{
    public AudioMixer Audiomixer;
    public void SetVolume (float Volume)
    {
        Audiomixer.SetFloat("Volume", Volume);
    }

    public void SetQualityLow()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void SetQualityHigh()
    {
        QualitySettings.SetQualityLevel(3);
    }
}
