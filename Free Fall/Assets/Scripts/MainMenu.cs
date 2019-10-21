using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region Public
    public GameObject mainMenu;
    public GameObject settingsMenu;
    #endregion

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void BackToMain()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
