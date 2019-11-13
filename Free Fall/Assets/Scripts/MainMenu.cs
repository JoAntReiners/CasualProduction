using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Advertisements;

public class MainMenu : MonoBehaviour
{
    #region Public
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public Slider slider;
    public AudioMixer mixer;
    #endregion

    #region Private
    private string gameID = "3340866";
    private string placementId = "bannerPlacement";
    [SerializeField] private bool testMode = true;
    #endregion

    public void Play()
    {
        StopAllCoroutines();
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
