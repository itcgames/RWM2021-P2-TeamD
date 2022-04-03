using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class ItemManager : MonoBehaviour
{

    public static ItemManager instance;

    public ItemInventory[] items;
    public GameObject buttonPrefab;
    public Text textPrefab;
    GameObject itemCanvas;
    GameObject desc;
    GameObject MemeberSelect;
    GameObject m_member1;
    GameObject m_member2;
    GameObject m_member3;
    GameObject m_member4;
    Text desc1;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    public void setAllItems()
    {
            MemeberSelect = GameObject.Find("MemberSelection");
            itemCanvas = GameObject.Find("Itemarea");
            desc = GameObject.Find("Description");



        foreach (ItemInventory i in items)
        {
            //creates the item
            if (i.m_amount > 0)
            {
                GameObject newButton = Instantiate(buttonPrefab) as GameObject;
                newButton.transform.SetParent(itemCanvas.transform, false);
                newButton.GetComponentInChildren<Text>().text = i.m_name + " x" + i.m_amount;

                if (SceneManager.GetActiveScene().name == "Pause")
                {
                    newButton.GetComponent<Button>().onClick.AddListener(() =>
                    {
                        ChangeDesc(i.m_desc);
                        MemeberSelect.transform.position = new Vector3(487, 295, 0);
                        selectPartyMemeber(i.m_name);
                        i.m_amount--;
                        newButton.GetComponentInChildren<Text>().text = i.m_name + " x" + i.m_amount;
                        if (i.m_amount == 0)
                        {
                            Destroy(newButton);
                        }
                    });
                    setupPartyMembers();
                }
                else if (SceneManager.GetActiveScene().name == "ItemShop")
                {
                    newButton.GetComponent<Button>().onClick.AddListener(() => {

                        FindObjectOfType<PlayerAndGameInfo>().infos.m_gil += i.m_cost / 2;
                        i.m_amount--;
                        newButton.GetComponentInChildren<Text>().text = i.m_name + " x" + i.m_amount;
                        if (i.m_amount == 0)
                        {
                            Destroy(newButton);
                        }
                    });
                }

            }

        }
    }



    public void updateItemAmount(GameObject newbutton, ItemInventory i)
    {
        newbutton.GetComponentInChildren<Text>().text = i.m_name + " x" + i.m_amount;
    }

    public void AddItem(string t_name)
    {
        ItemInventory itemDetail = Array.Find(items, items => items.m_name == t_name);
        if (itemDetail == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }

        itemDetail.m_amount++;

    }

    public void UseItem(string t_name, int t_number)
    {
        ItemInventory itemDetail = Array.Find(items, items => items.m_name == t_name);
        if (itemDetail == null)
        {
            Debug.LogWarning("Item: " + name + " not found!");
            return;
        }
       
        switch (t_number)
        {
            case 1:
                if(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeHP.Value + itemDetail.m_effects > FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeHPMax.Value)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeHP.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_type);
                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[0].m_attributeHP.Value += itemDetail.m_effects;
                }
                break;
            case 2:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeHP.Value + itemDetail.m_effects > FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeHPMax.Value)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeHP.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_type);
                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[1].m_attributeHP.Value += itemDetail.m_effects;
                }
                break;
            case 3:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeHP.Value + itemDetail.m_effects > FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeHPMax.Value)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeHP.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_type);
                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[2].m_attributeHP.Value += itemDetail.m_effects;
                }
                break;
            case 4:
                if (FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeHP.Value + itemDetail.m_effects > FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeHPMax.Value)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeHP.Value = PartyUtil.MaxHealth(FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_type);
                }
                else
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.character[3].m_attributeHP.Value += itemDetail.m_effects;
                }
                break;
            default:
                break;
        }
        setupPartyMembers();
        MemeberSelect.transform.position = new Vector3(25, -532, 0);

    }

    public void ChangeDesc(string t_desc)
    {
        if (desc1 == null)
        {
            desc1 = Instantiate(textPrefab) as Text;

            desc1.transform.SetParent(desc.transform, false);
            desc1.transform.position = desc.transform.position;
        }

        desc1.text = t_desc;
    }

    public void selectPartyMemeber(string name)
    {
        m_member1.GetComponent<Button>().onClick.AddListener(() =>
        { {
                UseItem(name, 1); } });

        m_member2.GetComponent<Button>().onClick.AddListener(() =>
        { {
                UseItem(name, 2); } });

        m_member3.GetComponent<Button>().onClick.AddListener(() =>
        { {
                UseItem(name, 3); } });

        m_member4.GetComponent<Button>().onClick.AddListener(() =>
        { {
                UseItem(name, 4); } });
    }

    public void setupPartyMembers()
    {
        m_member1 = GameObject.Find("Member1");
        m_member2 = GameObject.Find("Member2");
        m_member3 = GameObject.Find("Member3");
        m_member4 = GameObject.Find("Member4");

        m_member1.GetComponentInChildren<Text>().text = FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[0].m_name + "'s health " + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[0].m_attributeHP.Value.ToString() + "/" + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[0].m_attributeHPMax.Value.ToString();
        m_member2.GetComponentInChildren<Text>().text = FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[1].m_name + "'s health " + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[1].m_attributeHP.Value.ToString() + "/" + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[1].m_attributeHPMax.Value.ToString();
        m_member3.GetComponentInChildren<Text>().text = FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[2].m_name + "'s health " + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[2].m_attributeHP.Value.ToString() + "/" + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[2].m_attributeHPMax.Value.ToString();
        m_member4.GetComponentInChildren<Text>().text = FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[3].m_name + "'s health " + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[3].m_attributeHP.Value.ToString() + "/" + FindObjectOfType<PlayerAndGameInfo>()
            .infos.character[3].m_attributeHPMax.Value.ToString();
    }
}
