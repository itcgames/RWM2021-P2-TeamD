using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    // Start is called before the first frame update
    public static Options instance;
    [SerializeField]
    GameObject characterInfo;
    [SerializeField]
    public Slider m_sfxVolume;
    [SerializeField]
    public Slider m_musicVolume;
    [SerializeField]
    public Toggle m_isMuted;

    void Awake()
    {
        instance = this;
        m_sfxVolume.value = characterInfo.GetComponent<PlayerAndGameInfo>().infos.m_sfxVolume;
        m_musicVolume.value = characterInfo.GetComponent<PlayerAndGameInfo>().infos.m_musicVolume;
        m_isMuted.isOn = characterInfo.GetComponent<PlayerAndGameInfo>().infos.m_isMuted;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        characterInfo.GetComponent<PlayerAndGameInfo>().settingSetup(m_sfxVolume.value, m_musicVolume.value, m_isMuted.isOn);
    }
}
