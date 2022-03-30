using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    bool mute;
    float music, sfx;


    public static AudioManager instance;

    public GameObject OptionsMenu;


    public Sound[] sounds;
    public Sound[] musics;


    private void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }


        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.loop = s.loop;
        }

        foreach (Sound m in musics)
        {
            m.source = gameObject.AddComponent<AudioSource>();
            m.source.clip = m.clip;
            m.source.loop = m.loop;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    public float getMusicVolume()
    {
        return music;
    }
    public float getSFXVolume()
    {
        return sfx;
    }
    public bool getMuteVolume()
    {
        return mute;
    }

    private void Start()
    {
        PlayMusic("Theme");
    }


    public void playClick()
    {
        PlaySFX("ButtonClick");
    }


    public void PlaySFX(string name)
    {
        Sound sfx = Array.Find(sounds, sound => sound.name == name);
        if (sfx == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        sfx.source.Play();
    }

    public void PlayMusic(string name)
    {

        Sound music = Array.Find(musics, sound => sound.name == name);
        if (music == null)
        {
            Debug.LogWarning("Music: " + name + " not found!");
            return;
        }
        music.source.Play();

    }
    public void PauseMusic(string name)
    {

        Sound music = Array.Find(musics, sound => sound.name == name);
        if (music == null)
        {
            Debug.LogWarning("Music: " + name + " not found!");
            return;
        }
        music.source.Pause();

    }

    public void MuteAll()
    {

        if(Options.instance.m_isMuted.isOn == true)
        {
            foreach (Sound s in sounds)
            {
                s.source.mute = true;
            }

            foreach (Sound m in musics)
            {
                m.source.mute = true;
            }
        }
        else
        {
            foreach (Sound s in sounds)
            {
                s.source.mute = false;
            }

            foreach (Sound m in musics)
            {
                m.source.mute = false;
            }
        }
    }


    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Pause" ||
            SceneManager.GetActiveScene().name == "Menu")
        {
            if (Options.instance.gameObject.activeSelf)
            {
                music = Options.instance.m_musicVolume.value;
                sfx = Options.instance.m_sfxVolume.value;
                mute = Options.instance.m_isMuted.isOn;

                foreach (Sound s in sounds)
                {
                    s.source.volume = sfx;
                }

                foreach (Sound m in musics)
                {
                    m.source.volume = music;
                }
            }

        }

    }
}
