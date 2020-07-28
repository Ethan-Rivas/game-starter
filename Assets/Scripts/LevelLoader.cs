using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;

    public AudioSource MusicPlayer;
    public AudioSource EffectsPlayer;

    public void LoadLevel (int index)
    {
        MusicPlayer.Stop();
        EffectsPlayer.Stop();

        StartCoroutine(LoadAsynchronousy(index));
    }

    IEnumerator LoadAsynchronousy (int index)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(index);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;

            yield return null;
        }
    }
}