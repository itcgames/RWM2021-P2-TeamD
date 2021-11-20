using UnityEngine;
using UnityEngine.UI;

public class UseItem : MonoBehaviour
{
    public GameObject Item;
    public int amount;
    public string itemName;
    public int healAmount;
    public int PlayerHealth;
    public int max_health;
    public string playername;
   public Text playerHP;

    // Start is called before the first frame update
    void Start()
    {
      
    }
    private void OnEnable()
    {
        playerHP.text = playername + " \n HP" + PlayerHealth.ToString() + "/ " + max_health.ToString();
      
    }
    // Update is called once per frame
    void Update()
    {
        amount = Item.GetComponent<setupItem>().getAmount();
        Item.GetComponentInChildren<Text>().GetComponentInChildren<Text>().text = itemName +" x " + amount.ToString();
        
        if(amount == 0)
        {
            Destroy(Item);
        }
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
        if (amount> 0 && PlayerHealth != 0)
        {
            Item.GetComponent<setupItem>().changeAmount(1);
        }
    }

   
}
