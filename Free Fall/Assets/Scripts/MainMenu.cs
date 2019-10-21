using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    #region Public
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public Slider slider;
    public AudioMixer mixer;
    #endregion

    public void Play()
    {
        Time.timeScale = 1;
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

    public void setVolume()
    {
        mixer.SetFloat("Volume", slider.value);
    }
}
