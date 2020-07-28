using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVolume : MonoBehaviour
{
    public AudioSource music;
    public AudioSource effects;

    public Slider musicSlider;
    public Slider effectsSlider;
    
    // Save Volume
    public void SaveVolume()
    {
        SaveGameSystem.SaveVolume(music, effects);
    }

    // Volume Loader
    public void LoadVolume()
    {
        GameVolumeData data = SaveGameSystem.LoadVolume();

        musicSlider.value = data.MusicVolume * 10;
        effectsSlider.value = data.EffectsVolume * 10;
    }
}
