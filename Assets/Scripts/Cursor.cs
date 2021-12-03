using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    List<Vector2> cursorInvPositions;
    List<Vector2> cursorCharPositions;
    int currentInvPos = 0;
    int currentCharPos = 0;
    public ScreenSystem t_screenSystem;
    bool pickChar;
    bool activeInventories;

    // Start is called before the first frame update
    void Start()
    {
        activeInventories = false;
        pickChar = false;
        cursorInvPositions = new List<Vector2>();

        cursorInvPositions.Add(new Vector2(-425, -90));
        cursorInvPositions.Add(new Vector2(-425, -140));
        cursorInvPositions.Add(new Vector2(-425, -190));
        cursorInvPositions.Add(new Vector2(-425, -240));
        cursorInvPositions.Add(new Vector2(-425, -290));

        cursorCharPositions = new List<Vector2>();
        cursorCharPositions.Add(new Vector2(-150, 300));
        cursorCharPositions.Add(new Vector2(200,300));
        cursorCharPositions.Add(new Vector2(-150, -50));
        cursorCharPositions.Add(new Vector2(200, -50));

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
                MoveUp();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveDown();
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
                MoveUp1();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                MoveDown1();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                MoveRight();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            else if (Input.GetKeyDown(KeyCode.X))
            {
                GoToCharInventory();
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GoBack();
        }
    }

    public void UseFunctionality()
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
    public void GoToCharInventory()
    {
        t_screenSystem.GoToInventoryScreen(currentInvPos);
    }
    public void MoveUp()
    {
        if (currentInvPos > 0)
            currentInvPos--;
    }
    public void MoveDown()
    {
        if (currentInvPos < 4)
            currentInvPos++;
    }
    public void MoveRight()
    {
        if (currentCharPos != 1 && currentCharPos != 3)
        {
            if (currentCharPos == 0)
                currentCharPos = 1;
            else
                currentCharPos = 3;
        }
    }
    public void MoveLeft()
    {
        if (currentCharPos != 0 && currentCharPos != 2)
        {
            if (currentCharPos == 1)
                currentCharPos = 0;
            else
                currentCharPos = 2;
        }
    }
    public void MoveUp1()
    {
        if (currentCharPos != 0 && currentCharPos != 1)
        {
            if (currentCharPos == 2)
                currentCharPos = 0;
            else
                currentCharPos = 1;
        }
    }
    public void MoveDown1()
    {
        if (currentCharPos != 2 && currentCharPos != 3)
        {
            if (currentCharPos == 0)
                currentCharPos = 2;
            else
                currentCharPos = 3;
        }
    }
    public void GoBack()
    {
        for (int i = 0; i <= 4; i++)
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
