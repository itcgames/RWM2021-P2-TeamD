using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public static Options instance;
    [SerializeField]
    public Slider m_sfxVolume;
    [SerializeField]
    public Slider m_musicVolume;
    [SerializeField]
    public Toggle m_isMuted;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        m_sfxVolume.value = 0.8f;
        m_musicVolume.value = 0.8f;
        m_isMuted.isOn = false;


        DontDestroyOnLoad(this.gameObject);
    }
}