using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorWeapon : MonoBehaviour
{
    private GameObject weapom;
    public float attack1;
    public float attack2;
    public float attack3;
    public float attack4;

    // Start is called before the first frame update
    void Start()
    {
        attack1 = 0;
        attack2 = 0;
        attack2 = 0;
        attack2 = 0;

    }

    // Update is called once per frame
    void Update()
    {

        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip);
        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.isEquiped(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip);


        this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name;


    }
    private void OnEnable()
    {



        this.transform.GetChild(0).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name;
        this.transform.GetChild(0).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name;
        this.transform.GetChild(1).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name;
        this.transform.GetChild(2).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(0).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(1).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(2).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name;
        this.transform.GetChild(3).transform.GetChild(0).GetChild(3).GetComponent<Text>().text = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name;

    }

    public void setNameBlank(int i)
    {

        switch (i)
        {
            case 0:

                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = 0;


                break;
            case 1:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = 0;

                break;
            case 2:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = 0;

                break;
            case 3:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = 0;

                break;
            case 4:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = 0;

                break;
            case 5:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = 0;

                break;
            case 6:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = 0;

                break;
            case 7:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = 0;

                break;
            case 8:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = 0;

                break;
            case 9:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = 0;

                break;
            case 10:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = 0;

                break;
            case 11:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = 0;

                break;
            case 12:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = 0;

                break;
            case 13:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = 0;

                break;
            case 14:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = 0;

                break;
            case 15:
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = " ";
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Equip = false;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Value = 0;
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = 0;
                break;


        }
       

    }
    public void Equiping(int i, bool equipped)
    {

        switch (i)
        {
            case 0:

                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = attack1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Value;
                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name == " "))
                    {

                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Remove(0, 2);
                     FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value += 1;

                    }
                }

                break;
            case 1:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = attack1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Remove(0, 2);
                     FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value += 1;


                    }
                }

                break;
            case 2:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = attack1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Remove(0, 2);
                     FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value += 1;

                    }
                }
                break;
            case 3:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeAttack.Value = attack1 + FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Remove(0, 2);
                     FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value += 1;

                    }
                }

                break;
            case 4:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2;

                    }
                }
                break;
            case 5:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2;

                    }
                }

                break;
            case 6:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2;

                    }
                }

                break;
            case 7:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2 + FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeAttack.Value = attack2;

                    }
                }
                break;
            case 8:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3;

                    }
                }

                break;
            case 9:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3;

                    }
                }

                break;
            case 10:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3;

                    }
                }
                break;
            case 11:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3 + FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeAttack.Value = attack3;

                    }
                }
                break;
            case 12:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4;

                    }
                }
                break;
            case 13:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4;

                    }
                }

                break;
            case 14:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Value;

                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4;

                    }
                }

                break;
            case 15:
                if (equipped && !FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name == " "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = "E:" + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name;
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4 + FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Value;


                }
                else if (!equipped)
                {
                    if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.StartsWith("E:") && !(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name == " "))
                    {
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Remove(0, 2);
                        FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeAttack.Value = attack4;

                    }
                }

                break;

        }
    }
    public void Upgrading(int i,int upgradeAmount)
    {
        switch (i)
        {
            case 0:


                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Replace((upgradeAmount-1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name + " + " + upgradeAmount.ToString();

                }
                if(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon1.Value += 1;
                break;
            case 1:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon2.Value += 1;
                break;
            case 2:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon3.Value += 1;
                break;
            case 3:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_weapon4.Value += 1;
                break;
            case 4:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon1.Value += 1;
                break;
            case 5:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon2.Value += 1;
                break;
            case 6:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon3.Value += 1;
                break;
            case 7:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_weapon4.Value += 1;
                break;
            case 8:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon1.Value += 1;
                break;
            case 9:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon2.Value += 1;
                break;
            case 10:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon3.Value += 1;
                break;
            case 11:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_weapon4.Value += 1;
                break;
            case 12:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon1.Value += 1;
                break;
            case 13:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon2.Value += 1;
                break;
            case 14:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon3.Value += 1;
                break;
            case 15:

                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains(" + "))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Replace((upgradeAmount - 1).ToString(), upgradeAmount.ToString());

                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name = FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name + " + " + upgradeAmount.ToString();

                }
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Name.Contains(" + 10"))
                {
                    break;
                }
                FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_weapon4.Value += 1;
                break;

        }
    }
}



