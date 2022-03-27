using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TavernMiniGame : MonoBehaviour
{

    KeyCode[] keyCodes = new KeyCode[4];
    int keyNeeded;

    float keyPressTimeInterval = 2.0f;
    float timeLeft;

    const int PERCENT_NEEDED = 100;
    int currentPercent = 0;

    const int LEVELS_NEEDED = 3;
    int currentLevels = 0;

    void Start()
    {
        timeLeft = keyPressTimeInterval;

        keyCodes[0] = KeyCode.A;
        keyCodes[1] = KeyCode.W;
        keyCodes[2] = KeyCode.S;
        keyCodes[3] = KeyCode.D;

        keyNeeded = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {

        if(timeLeft > 0f)
        {
            timeLeft -= Time.deltaTime;

            if (Input.GetKeyDown(keyCodes[keyNeeded]))
            {
                addPercent();
                timeLeft = keyPressTimeInterval;
                keyNeeded = Random.Range(0, 4);
            }
        }
        else
        {
            timeLeft = keyPressTimeInterval;
            keyNeeded = Random.Range(0, 4);
        }

    }

    void addPercent()
    {
        currentPercent += 10;

        Debug.Log(currentPercent);

        if (currentPercent >= PERCENT_NEEDED)
        {
            currentLevels++;
            currentPercent = 0;

        }

        if (currentLevels >= LEVELS_NEEDED)
            FindObjectOfType<ScreenSystem>().EndGame();
    }
}
