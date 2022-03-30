using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    [SerializeField]
    public Slider m_sfxVolume;
    [SerializeField]
    public Slider m_musicVolume;
    [SerializeField]
    public Toggle m_isMuted;


    void Awake()
    {
        m_sfxVolume.value = Setting.instance.sfx;
        m_musicVolume.value = Setting.instance.music;
        m_isMuted.isOn = Setting.instance.mute;
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Pause" ||
            SceneManager.GetActiveScene().name == "Menu")
        {
            if (gameObject.activeSelf)
            {
                Setting.instance.sfx = m_sfxVolume.value;
                Setting.instance.music = m_musicVolume.value;
                Setting.instance.mute = m_isMuted.isOn;

                print("sfx:" + Setting.instance.sfx);
                print("music:" + Setting.instance.music);
                print("Mute is " + Setting.instance.mute);
            }
        }
    }

    public float getSFX()
    {
        return m_sfxVolume.value;
    }

    public float getMusic()
    {
        return m_musicVolume.value;
    }
    public bool getMute()
    {
        return m_isMuted.isOn;
    }
}