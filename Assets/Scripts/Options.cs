using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public static Options instance;
    [SerializeField]
    public AudioManager audioManager;
    [SerializeField]
    public Slider m_sfxVolume;
    [SerializeField]
    public Slider m_musicVolume;
    [SerializeField]
    public Toggle m_isMuted;

    void Awake()
    {
        instance = this;

        if(SceneManager.GetActiveScene().name == "Pause")
        {
            m_sfxVolume.value = audioManager.getSFXVolume();
            m_musicVolume.value = audioManager.getMusicVolume();
            m_isMuted.isOn = audioManager.getMuteVolume();

        }

        DontDestroyOnLoad(this.gameObject);
    }
}
