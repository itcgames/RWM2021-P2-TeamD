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
    float stun = 1.0f;
    bool stuned = false;
    const int PERCENT_NEEDED = 100;
    int currentPercent = 0;

    const int LEVELS_NEEDED = 3;
    int currentLevels = 0;
    Slider bar;
    public GameObject levelParent;
    public GameObject buttonDidplay;

    private TavernData data;

    public bool isEnemy = false;

    void Start()
    {

        data = new TavernData { id = 6, missPressedKeys = 0, tavernMinigameWon = 0 };

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
               if(stuned)
                {
                    stun -= Time.deltaTime;
                    if(stun <= 0)
                    {
                        stuned = false;
                    }
                }
                if (Input.anyKeyDown && !stuned)
                {
                    if(Input.GetKeyDown(keyCodes[keyNeeded]))
                    {
                        addPercent();
                        pickKey();
                    }
                    else
                    {
                        data.missPressedKeys++;
                        if (currentPercent >= 0)
                        {
                            currentPercent -= 10;
                            stun = 1.0f;
                            stuned = true;
                            bar.value = currentPercent;
                        }
                        
                        pickKey();
                    }
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
        {
            if (!isEnemy)
            {
                data.tavernMinigameWon = 1;
            }

            DataCollectionUtility.PostData(data, this);
            AudioManager.instance.PauseMusic("Theme");
            AudioManager.instance.PlayMusic("EndCredits");
            FindObjectOfType<ScreenSystem>().WinGame();

        }
        bar.value = currentPercent;
    }

    void pickKey()
    {

        timeLeft = keyPressTimeInterval;
        keyNeeded = Random.Range(0, 4);
        buttonDidplay.GetComponent<Text>().text = keyCodes[keyNeeded].ToString();
    }
}
