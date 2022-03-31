﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_shopSelection;
    [SerializeField]
    GameObject m_shopItems;
    [SerializeField]
    GameObject m_sellItems;
    [SerializeField]
    GameObject m_confirmSelection;
    [SerializeField]
    Text m_dialog;
    [SerializeField]
    Text m_gilText;

    [SerializeField]
    GameObject m_member1;
    [SerializeField]
    GameObject m_member2;
    [SerializeField]
    GameObject m_member3;
    [SerializeField]
    GameObject m_member4;
    [SerializeField]
    GameObject m_player;
    [SerializeField]
    GameObject m_data;

    public GameObject m_itemArea;
    public GameObject m_itemPrefab;


    int type;

    bool m_purchase;
    bool m_sell;
    bool m_clinicPaid;


    private void Start()
    {
        m_dialog.text = "Welcome!";
        if (!Utilities.s_testMode) m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";
        else m_gilText.text = ""; // don't need for testing

        if (SceneManager.GetActiveScene().name == "ClinicShop")
        {
            setupClinic();
        }
    }

    private void Update()
    {
        backSelection();

        if (SceneManager.GetActiveScene().name == "ClinicShop")
        {
            if (fullHealth())
            {
                m_dialog.text = "Who shall be revived....";
            }
            else
            {
                m_dialog.text = "You do not need my help now.";
                m_shopSelection.SetActive(false);
                if (Input.anyKey)
                {
                    leaveShop();
                }
            }
        }
    }


    public void openShop()
    {
        m_shopItems.SetActive(true);
        m_shopSelection.SetActive(false);
        m_dialog.text = "What do you need";
    }

    public void sellShop()
    {
        m_sellItems.SetActive(true);
        m_shopSelection.SetActive(false);
        m_dialog.text = "Whose item do want to sell?";
    }

    public void ClinicPayment()
    {
        m_confirmSelection.SetActive(true);
        m_shopSelection.SetActive(false);
    }

    public void leaveShop()
    {
        SceneManager.LoadScene("Town");
    }

    public void selling()
    {
        m_sell = true;
        checkSelling();
    }
    public void cancelSelling()
    {
        m_sell = false;
        checkSelling();
    }


    void backSelection()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            m_shopSelection.SetActive(true);
        }
    }
    public void Purchased()
    {
        m_purchase = true;
        checkPurchase();
    }

    public void CancelPurchase()
    {
        m_purchase = false;
        checkPurchase();
    }

    public void ClinicPaid()
    {
        m_clinicPaid = true;
        checkClinicPaid();
    }

    public void ClinicNoPay()
    {
        m_clinicPaid = false;
        checkClinicPaid();
    }

    public void checkPurchase()
    {
        if (m_purchase)
        {
            // 400 > 60/75
            if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= m_shopItems.GetComponent<ItemCost>().costProduct())
            {
                m_dialog.text = "Thank you!\nWhat else?";
                // subtract the gil here
                FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= m_shopItems.GetComponent<ItemCost>().costProduct();
                m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";

                // add the item here
                if (m_shopItems.GetComponent<ItemCost>().GetInventory() == 0)
                {
                    //GameObject gameObject = Instantiate(m_itemPrefab, m_itemArea.transform);
                    //m_inventory
                }
                m_shopItems.GetComponent<ItemCost>().addInventory();
                m_confirmSelection.SetActive(false);
            }
            else
            {
                m_dialog.text = "You can't\nafford that.";
            }
        }
        else
        {
            m_dialog.text = "Too bad\n...\nSomething else?";
        }
        m_purchase = false;
        m_confirmSelection.SetActive(false);
        m_shopSelection.SetActive(true);

    }

    public void checkSelling()
    {
        if (m_sell)
        {
            // checks the armor inventory of the member
            if (m_shopItems.GetComponent<ItemCost>().GetInventory() > 1) //!Change THIS FOR ARMOR/WEAPON
            {
                m_dialog.text = "Thank you!\nWhat else?";
                // add the gil here
                FindObjectOfType<PlayerAndGameInfo>().infos.m_gil += m_shopItems.GetComponent<ItemCost>().sellProduct();
                m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";
                // remove the item here
                if (m_shopItems.GetComponent<ItemCost>().GetInventory() <= 0)
                {
                    GameObject gameObject = m_itemPrefab;
                    Destroy(gameObject);
                }
                m_shopItems.GetComponent<ItemCost>().removeInventory();
                m_confirmSelection.SetActive(false);

            }
            else
            {
                // if no items in the inventory
                m_dialog.text = "You have nothing to sell...\nanything else?";
            }
        }
        else
        {
            m_dialog.text = "Too bad\n...\nSomething else?";
            m_confirmSelection.SetActive(false);
        }
        m_sell = false;
        m_confirmSelection.SetActive(false);
        m_shopSelection.SetActive(true);
    }

    public void checkClinicPaid()
    {

        if (m_clinicPaid)
        {
            if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil >= 40)
            {
                type = FindButton();
                //health max here
                switch (type)
                {
                    case 1:
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_type1);
                        Debug.Log("Health: " + FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value);
                        break;
                    case 2:
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_type2);
                        Debug.Log("Health: " + FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value);
                        break;
                    case 3:
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_type3);
                        Debug.Log("Health: " + FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value);
                        break;
                    case 4:
                        FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_type4);
                        Debug.Log("Health: " + FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value);
                        break;
                    default:
                        break;
                }

                m_dialog.text = "Thank you!\nWhat else?";
                // subtract the gil here
                FindObjectOfType<PlayerAndGameInfo>().infos.m_gil -= 40;
                m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";
            }
            else
            {
                m_dialog.text = "You can't\nafford that.";
            }
        }
        else
        {
            m_dialog.text = "Who shall be revived....";
        }
        m_confirmSelection.SetActive(false);
        m_shopSelection.SetActive(true);
        fullHealth();
        m_clinicPaid = false;

    }

    public void setupClinic()
    {
        Debug.Log(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value);
        m_member1 = GameObject.Find("Member1");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value, m_member1, FindObjectOfType<PlayerAndGameInfo>().infos.m_name1);
        m_member2 = GameObject.Find("Member2");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value, m_member2, FindObjectOfType<PlayerAndGameInfo>().infos.m_name2);
        m_member3 = GameObject.Find("Member3");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value, m_member3, FindObjectOfType<PlayerAndGameInfo>().infos.m_name3);
        m_member4 = GameObject.Find("Member4");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value, m_member4, FindObjectOfType<PlayerAndGameInfo>().infos.m_name4);
    }

    public void checkHealth(float t_health, GameObject t_data, string t_name)
    {
        if (t_health <= 0)
        {
            t_data.GetComponent<Text>().text = t_name;
            t_data.SetActive(true);
        }
        else
        {
            t_data.SetActive(false);
        }
    }

    public bool fullHealth()
    {
        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value <= 0 || FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value <= 0 ||
            FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value <= 0 || FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int FindButton()
    {
        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value <= 0)
        {
            Button btn = m_member1.GetComponent<Button>();
            type = 1;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP2.Value <= 0)
        {
            Button btn = m_member2.GetComponent<Button>();
            type = 2;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP3.Value <= 0)
        {
            Button btn = m_member3.GetComponent<Button>();
            type = 3;
        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP4.Value <= 0)
        {
            Button btn = m_member4.GetComponent<Button>();
            type = 4;
        }

        return type;
    }
}