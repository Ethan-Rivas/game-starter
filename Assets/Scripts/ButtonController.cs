using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonController : MonoBehaviour
{
    // Source and Clips declaration
    public AudioSource AudioSrc;
    public AudioClip hoverBeep;
    public AudioClip clickBeep;

    public TextMeshProUGUI textMeshPro;
    private Color32 normal = new Color32(255, 128, 0, 255);
    private Color32 hover = new Color32(200, 102, 0, 255);
    private Color32 click = new Color32(142, 72, 0, 255);

    // Button on Hover
    public void buttonHover()
    {
        AudioSrc.PlayOneShot(hoverBeep);

        textMeshPro.color = hover;
    }

    // Button on Click
    public void buttonClick()
    {
        AudioSrc.PlayOneShot(clickBeep);

        textMeshPro.color = click;
    }

    // Button on Click
    public void buttonNormal()
    {
        textMeshPro.color = normal;
    }
}
