using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    public static Options instance;
    [SerializeField]
    public Slider m_sfxVolume;
    [SerializeField]
    public Slider m_musicVolume;
    [SerializeField]
    public Toggle m_isMuted;

    void Awake()
    {
        instance = this;

        //if(SceneManager.)

        DontDestroyOnLoad(this.gameObject);
    }
}
