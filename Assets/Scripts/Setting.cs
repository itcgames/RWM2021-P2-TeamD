using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public static Setting instance;

    public bool mute;
    public float music, sfx;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        music = 0.4f;
        sfx = 0.8f;
        mute = false;

        DontDestroyOnLoad(this.gameObject);
    }

}