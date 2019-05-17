using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Control the volume master of app
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Control the resolution of app
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
