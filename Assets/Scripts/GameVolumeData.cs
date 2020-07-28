using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameVolumeData
{
    public float MusicVolume;
    public float EffectsVolume;

    public GameVolumeData(AudioSource music, AudioSource effects)
    {
        MusicVolume = music.volume;
        EffectsVolume = effects.volume;
    }

}
