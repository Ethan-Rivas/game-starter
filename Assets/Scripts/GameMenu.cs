using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    // Back to Main Menu
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
