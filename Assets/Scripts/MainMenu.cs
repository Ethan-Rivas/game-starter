using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Slider musicSlider;
    public Slider effectsSlider;

    void Start()
    {
        GameVolumeData data = SaveGameSystem.LoadVolume();

        musicSlider.value = data.MusicVolume * 10;
        effectsSlider.value = data.EffectsVolume * 10;
    }

    // Load Saved Game
    public void LoadGame()
    {
        Debug.Log("Loading...");
    }

    // Exit Game
    public void ExitGame()
    {
        Application.Quit();
    }
}
