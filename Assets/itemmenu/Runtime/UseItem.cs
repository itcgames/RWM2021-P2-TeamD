using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public GameObject Item;
    public int healAmount = 5;
    public int PlayerHealth = 55;
    public int max_health= 68;
    public string playername= "Player";
    public Text playerHP;

     void OnEnable()
    {
        playerHP = this.gameObject.GetComponent<Text>();
        playerHP.text = playername + " \n HP" + PlayerHealth.ToString() + "/ " + max_health.ToString();
    }

    public void heal()
    {
        if (PlayerHealth < max_health && PlayerHealth != 0)
        {
            PlayerHealth += healAmount;
        }
        if(PlayerHealth > max_health)
        {
            PlayerHealth = max_health;
        }
        
    }
    public void use()
    {
        if (Item.GetComponent<setupItem>().getAmount() > 0 && PlayerHealth != 0)
        {
            Item.GetComponent<setupItem>().changeAmount(-1);

        }
        if (Item.GetComponent<setupItem>().getAmount() == 0)
        {
            Destroy(Item);
        }
    }

   
}
