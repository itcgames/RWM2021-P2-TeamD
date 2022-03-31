using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TavernMiniGame : MonoBehaviour
{

    KeyCode[] keyCodes = new KeyCode[4];
    int keyNeeded;

    float keyPressTimeInterval = 2.0f;
    float enemyTimeInterval = 0.75f;
    float timeLeft;

    const int PERCENT_NEEDED = 100;
    int currentPercent = 0;

    const int LEVELS_NEEDED = 3;
    int currentLevels = 0;
    Slider bar;
    public GameObject levelParent;
    public GameObject buttonDidplay;

    public bool isEnemy = false;

    void Start()
    {
        timeLeft = keyPressTimeInterval;

        keyCodes[0] = KeyCode.A;
        keyCodes[1] = KeyCode.W;
        keyCodes[2] = KeyCode.S;
        keyCodes[3] = KeyCode.D;

        keyNeeded = Random.Range(0, 4);

        bar = this.gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!isEnemy)
        {
            if (timeLeft > 0f)
            {
                timeLeft -= Time.deltaTime;

                if (Input.GetKeyDown(keyCodes[keyNeeded]))
                {
                    addPercent();
                    pickKey();
                }
            }
            else
            {
                pickKey();
            }
        }
        else
        {
            if (timeLeft > 0f)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = enemyTimeInterval;
                addPercent();
            }
        }

    }

    void addPercent()
    {
        currentPercent += 10;

        Debug.Log(currentPercent);

        if (currentPercent >= PERCENT_NEEDED)
        {
            levelParent.transform.GetChild(currentLevels).gameObject.GetComponent<Image>().color = Color.green;
            currentLevels++;
            currentPercent = 0;
        }

        if (currentLevels >= LEVELS_NEEDED)
            FindObjectOfType<ScreenSystem>().EndGame();

        bar.value = currentPercent;
    }

    void pickKey()
    {

        timeLeft = keyPressTimeInterval;
        keyNeeded = Random.Range(0, 4);
        buttonDidplay.GetComponent<Text>().text = keyCodes[keyNeeded].ToString();
    }
}
