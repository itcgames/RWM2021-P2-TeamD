using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    GameObject m_player;
    [SerializeField]
    GameObject m_inventory;

    bool m_purchase;
    bool m_sell;


    private void Start()
    {
        m_dialog.text = "Welcome!";
        m_gilText.text = m_player.GetComponent<Player>().getGil().ToString() + " G";
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
            // 500 > 60/75
            if (m_player.GetComponent<Player>().getGil() > m_shopItems.GetComponent<ItemCost>().costProduct() + 100)
            {
                m_dialog.text = "Thank you!\nWhat else?";
                // subtract the gil here
                m_player.GetComponent<Player>().setGil(m_shopItems.GetComponent<ItemCost>().costProduct());
                m_gilText.text = m_player.GetComponent<Player>().getGil().ToString() + " G";
                // add the item here
                
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
            // checks the inventory of the member
            if (m_player.GetComponent<Player>().getGil() > m_shopItems.GetComponent<ItemCost>().costProduct() + 100)
            {
                m_dialog.text = "Thank you!\nWhat else?";
                // add the gil here
                m_player.GetComponent<Player>().setGil(m_shopItems.GetComponent<ItemCost>().sellProduct());
                m_gilText.text = m_player.GetComponent<Player>().getGil().ToString() + " G";
                // remove the item here

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



}
