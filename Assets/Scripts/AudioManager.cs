using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    bool mute;
    float music, sfx;
    private void Awake()
    {
        mute = Options.instance.m_isMuted.isOn;
        sfx = Options.instance.m_sfxVolume.value;
        music = Options.instance.m_musicVolume.value;
        print("music: " + music);
        print("sfx :" + sfx);
        print("Mute is " + mute);

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
}
