using System.Collections;
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

    bool m_purchase;
    bool m_sell;


    private void Start()
    {
        m_dialog.text = "Welcome!";
        m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";

        if (SceneManager.GetActiveScene().name == "ClinicShop")
        {
            setupClinic();
        }
    }

    private void Update()
    {
        backSelection();
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
                    GameObject gameObject = Instantiate(m_itemPrefab, m_itemArea.transform);
                    //m_inventory
                }
                m_shopItems.GetComponent<ItemCost>().addInventory();
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
        m_confirmSelection.SetActive(false);
        m_shopSelection.SetActive(true);

    }

    public void checkSelling()
    {
        if (m_sell)
        {
            // checks the armor inventory of the member
            if (FindObjectOfType<PlayerAndGameInfo>().infos.m_gil > m_shopItems.GetComponent<ItemCost>().costProduct()) //!Change THIS FOR ARMOR/WEAPON
            {
                m_dialog.text = "Thank you!\nWhat else?";
                // add the gil here
                FindObjectOfType<PlayerAndGameInfo>().infos.m_gil = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil + m_shopItems.GetComponent<ItemCost>().sellProduct();
                m_gilText.text = FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString() + " G";
                // remove the item here
                if (m_shopItems.GetComponent<ItemCost>().GetInventory() == 0)
                {
                    GameObject gameObject = m_itemPrefab;
                    Destroy(gameObject);
                }
                m_shopItems.GetComponent<ItemCost>().removeInventory();

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
        }
        m_confirmSelection.SetActive(false);
        m_shopSelection.SetActive(true);
    }


    public void checkPlayerHealth()
    {
        m_shopSelection.SetActive(true);
    }

    public void setupClinic()
    {
        m_member1 = GameObject.Find("Member1");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value, m_member1, FindObjectOfType<PlayerAndGameInfo>().infos.m_name1);
        m_member2 = GameObject.Find("Member2");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value, m_member2, FindObjectOfType<PlayerAndGameInfo>().infos.m_name2);
        m_member3 = GameObject.Find("Member3");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value, m_member3, FindObjectOfType<PlayerAndGameInfo>().infos.m_name3);
        m_member4 = GameObject.Find("Member4");
        checkHealth(FindObjectOfType<PlayerAndGameInfo>().infos.m_attributeHP1.Value, m_member4, FindObjectOfType<PlayerAndGameInfo>().infos.m_name4);
    }

    public void checkHealth(float t_health, GameObject t_data, string t_name)
    {
        if(t_health <= 0)
        {
            t_data.GetComponent<Text>().text = t_name;
            t_data.SetActive(true);
        }
        else
        {
            t_data.SetActive(false);
        }
    }

    public void ReviveMember()
    {
        m_data = EventSystem.current.currentSelectedGameObject.gameObject;
    }

}
