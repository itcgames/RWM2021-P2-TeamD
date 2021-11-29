using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    List<Vector2> cursorInvPositions;
    List<Vector2> cursorCharPositions;
    int currentInvPos = 0;
    int currentCharPos = 0;
    ScreenSystem t_screenSystem;
    bool pickChar;
    bool activeInventories;

    // Start is called before the first frame update
    void Start()
    {
        activeInventories = false;
        pickChar = false;
        cursorInvPositions = new List<Vector2>();

        cursorInvPositions.Add(new Vector2(-425, 100));
        cursorInvPositions.Add(new Vector2(-425, 50));
        cursorInvPositions.Add(new Vector2(-425, 0));
        cursorInvPositions.Add(new Vector2(-425, -50));
        cursorInvPositions.Add(new Vector2(-425, -100));

        cursorCharPositions = new List<Vector2>();
        cursorCharPositions.Add(new Vector2(-100, 300));
        cursorCharPositions.Add(new Vector2(200,300));
        cursorCharPositions.Add(new Vector2(-100, 0));
        cursorCharPositions.Add(new Vector2(200, 0));

        t_screenSystem = GameObject.Find("Canvas").GetComponent<ScreenSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pickChar)
        {
            this.gameObject.GetComponent<RectTransform>().localPosition = cursorInvPositions[currentInvPos];

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (currentInvPos > 0)
                    currentInvPos--;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (currentInvPos < 4)
                    currentInvPos++;
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                UseFunctionality();
            }
        }
        else
        {
            this.gameObject.GetComponent<RectTransform>().localPosition = cursorCharPositions[currentCharPos];

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(currentCharPos != 0 && currentCharPos != 1)
                {
                    if (currentCharPos == 2)
                        currentCharPos = 0;
                    else
                        currentCharPos = 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (currentCharPos != 2 && currentCharPos != 3)
                {
                    if (currentCharPos == 0)
                        currentCharPos = 2;
                    else
                        currentCharPos = 3;
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentCharPos != 1 && currentCharPos != 3)
                {
                    if (currentCharPos == 0)
                        currentCharPos = 1;
                    else
                        currentCharPos = 3;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentCharPos != 0 && currentCharPos != 2)
                {
                    if (currentCharPos == 1)
                        currentCharPos = 0;
                    else
                        currentCharPos = 2;
                }
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                t_screenSystem.GoToInventoryScreen(currentInvPos);
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            for(int i = 0; i <= 4; i++)
            {
                if (this.transform.parent.transform.GetChild(i).gameObject.activeInHierarchy)
                {
                    activeInventories = true;
                    break;
                }
                else
                    activeInventories = false;
            }
            if (activeInventories)
                t_screenSystem.GoToPauseScreen();
            else
                t_screenSystem.GoToGameplayScene();
        }
    }

    void UseFunctionality()
    {
        switch (currentInvPos)
        {
            case 0:
                t_screenSystem.GoToInventoryScreen(currentInvPos);
                break;
            case 1:
                pickChar = true;
                break;
            case 2:
                t_screenSystem.GoToInventoryScreen(currentInvPos);
                break;
            case 3:
                t_screenSystem.GoToInventoryScreen(currentInvPos);
                break;
            case 4:
                pickChar = true;
                break;
            default:
                break;
        }
    }
}
