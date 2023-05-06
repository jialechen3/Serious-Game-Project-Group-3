using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] private AudioSource background;

    public void BackToMenu()
    {
        SceneManager.LoadScene("main_menu_scene");
    }
    public void SetVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume") == true)
        {
            Load();
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        background.Play();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
