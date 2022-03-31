using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject manager;


    private void Start()
    {
        manager = GameObject.Find("AudioManager");
    }
    public void ClickSFX()
    {
        manager.GetComponent<AudioManager>().playClick();
    }

    public void Mute()
    {
        if (Setting.instance.mute == true)
        {
            manager.GetComponent<AudioManager>().MuteAll();
        }

    }
}
