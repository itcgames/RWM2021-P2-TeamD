using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public List<Vector2> cursorInvPositions;
    public List<Vector2> cursorCharPositions;
    public int currentInvPos = 0;
    public int currentCharPos = 0;
    int col2 = 0;
    public ScreenSystem t_screenSystem;
    public bool pickChar;
    public bool activeInventories;
    public bool isInventory;
    public bool isArmour= false;
    public bool isNavi = false;

    public bool isMenu;
    public List<GameObject> charAndImg;
    public Vector2[,] naviArmor;
    public Vector2[] useNavi;
    CharacterInfo info;
    int row = 0;
    int col = 0;
    CheckpointSystem checkpointSystem;

    public List<GameObject> charPickButtons;

    // Start is called before the first frame update
    void Start()
    {
        naviArmor = new Vector2[2,8];

        naviArmor[0, 0] = new Vector2( -180, 120 );
        naviArmor[1, 0] = new Vector2(116, 120);
        naviArmor[0, 1] = new Vector2(-180, 60);
        naviArmor[1, 1] = new Vector2(116, 60);
        naviArmor[0, 2] = new Vector2(-180, -17);
        naviArmor[1, 2] = new Vector2(116, -17);
        naviArmor[0, 3] = new Vector2(-180, -64);
        naviArmor[1, 3] = new Vector2(116, -64);
        naviArmor[0, 4] = new Vector2(-180, -148);
        naviArmor[1, 4] = new Vector2(116, -148);
        naviArmor[0, 5] = new Vector2(-180, -200);
        naviArmor[1, 5] = new Vector2(116, -200);
        naviArmor[0, 6] = new Vector2(-180, -267);
        naviArmor[1, 6] = new Vector2(116, -267);
        naviArmor[0, 7] = new Vector2(-180, -328);
        naviArmor[1, 7] = new Vector2(116, -328);

        useNavi = new Vector2[3];
        useNavi[0] = new Vector2(-180, 300);
        useNavi[1] = new Vector2(25, 300);
        useNavi[2] = new Vector2(220, 300);


        //activeInventories = false;
        //pickChar = false;
        //cursorInvPositions = new List<Vector2>();

        //cursorInvPositions.Add(new Vector2(-425, -90));
        //cursorInvPositions.Add(new Vector2(-425, -140));
        //cursorInvPositions.Add(new Vector2(-425, -190));
        //cursorInvPositions.Add(new Vector2(-425, -240));
        //cursorInvPositions.Add(new Vector2(-425, -290));

        //cursorCharPositions = new List<Vector2>();
        //cursorCharPositions.Add(new Vector2(-150, 300));
        //cursorCharPositions.Add(new Vector2(200,300));
        //cursorCharPositions.Add(new Vector2(-150, -50));
        //cursorCharPositions.Add(new Vector2(200, -50));

        t_screenSystem = GameObject.Find("Canvas").GetComponent<ScreenSystem>();

        info = new CharacterInfo();

        checkpointSystem = GameObject.FindObjectOfType<CheckpointSystem>();

        if (charPickButtons != null)
        {
            charPickButtons[0].SetActive(false);
            charPickButtons[1].SetActive(false);
            charPickButtons[2].SetActive(false);
            charPickButtons[3].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isInventory)
        {
            if (!pickChar)
            {
                charPickButtons[0].SetActive(false);
                charPickButtons[1].SetActive(false);
                charPickButtons[2].SetActive(false);
                charPickButtons[3].SetActive(false);

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
                    UseFunctionality(currentInvPos);
                }
            }
            else
            {
                charPickButtons[0].SetActive(true);
                charPickButtons[1].SetActive(true);
                charPickButtons[2].SetActive(true);
                charPickButtons[3].SetActive(true);

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
                    GoToCharInventory(currentCharPos);
                }
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                GoBack();
            }
        }
        else if (isArmour)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                isInventory = true;
                GoBack();
            }

            if (isNavi)
            {

                this.gameObject.GetComponent<RectTransform>().localPosition = useNavi[row];

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Debug.Log("Move right");

                    if (row == 2)
                    {
                        row = 0;
                    }
                    else
                    {
                        row++;
                    }


                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Debug.Log("Move right");

                    if (row == 0)
                    {
                        row = 2;
                    }
                    else
                    {
                        row--;
                    }



                }

                if (Input.GetKeyDown(KeyCode.X))
                {
                    isNavi = false;
                }
            }
            else
            {

                this.gameObject.GetComponent<RectTransform>().localPosition = naviArmor[row, col];


                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Debug.Log("Move right");

                    if (row == 1)
                    {
                        row = 0;
                    }
                    else
                    {
                        row++;
                    }


                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Debug.Log("Move right");

                    if (row == 0)
                    {
                        row = 1;
                    }
                    else
                    {
                        row--;
                    }


                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {


                    if (col == 7)
                    {
                        col = 0;
                    }
                    else
                    {
                        col++;
                    }


                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {


                    if (col == 0)
                    {
                        col = 7;
                    }
                    else
                    {
                        col--;
                    }
                }

                if (Input.GetKeyDown(KeyCode.X))
                {
                    isNavi = true;
                }
            }
        }
        else if (isMenu)
        {
            this.gameObject.GetComponent<RectTransform>().localPosition = cursorInvPositions[currentInvPos];

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (currentInvPos == 0)
                    currentInvPos = 1;
                else
                    currentInvPos--;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (currentInvPos == 1)
                    currentInvPos = 0;
                else
                    currentInvPos++;
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (currentInvPos == 0)
                    GameObject.FindObjectOfType<ScreenSystem>().ContinueGame();
                else
                    GameObject.FindObjectOfType<ScreenSystem>().GoToCharacterSelcetionScene();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (currentCharPos == 3)
                {
                    GameObject.FindObjectOfType<PlayerAndGameInfo>().SetCharacter(4, charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetName(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetImage(), charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute1(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute2(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetType(), charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute3());


                    FindObjectOfType<CheckpointSystem>().SaveData(JsonUtility.ToJson(FindObjectOfType<PlayerAndGameInfo>().GetCharInfo()));
                    GameObject.FindObjectOfType<ScreenSystem>().GoToGameplayScene();
                }
                else
                {

                    GameObject.FindObjectOfType<PlayerAndGameInfo>().SetCharacter(currentCharPos + 1, charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetName(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetImage(), charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute1(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute2(),
                        charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetType(), charAndImg[currentCharPos].GetComponent<CharNameAndImg>().GetAttribute3());
                    currentCharPos++;
                }

                this.gameObject.GetComponent<RectTransform>().localPosition = cursorCharPositions[currentCharPos];
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                charAndImg[currentCharPos].GetComponent<CharNameAndImg>().Next();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                charAndImg[currentCharPos].GetComponent<CharNameAndImg>().Previous();
            }
        }
    }

    public void SetIsNavi(bool navi)
    {
        isNavi = navi;
    }

    public void UseFunctionality(int invPos)
    {
        switch (invPos)
        {
            case 0:
                currentInvPos = invPos;
                t_screenSystem.GoToInventoryScreen(invPos);
                break;
            case 1:
                currentInvPos = invPos;
                pickChar = true;
                break;
            case 2:
                currentInvPos = invPos;
                t_screenSystem.GoToInventoryScreen(invPos);
                break;
            case 3:
                currentInvPos = invPos;
                isInventory = false;
                isArmour = true;
                isNavi = true;
                t_screenSystem.GoToInventoryScreen(invPos);
                break;
            case 4:
                currentInvPos = invPos;
                pickChar = true;
                break;
            default:
                break;
        }
    }
    public void GoToCharInventory(int charPos)
    {
        currentCharPos = charPos;
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
