using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PlayerAndGameInfo>() == null) return;

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished && CompareTag("Quest"))
        {
           
                this.transform.GetChild(0).gameObject.SetActive(false);
                this.transform.GetChild(1).gameObject.SetActive(false);
                this.transform.GetChild(2).gameObject.SetActive(false);
                this.enabled = false;
           
        }

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && CompareTag("Quest2"))
        {

            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.enabled = false;

        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished && CompareTag("Quest3"))
        {
            

            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.enabled = false;

        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished && CompareTag("Barrier"))
        {
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2.Equip = false;

            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2.Equip = false;
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2.Equip = false;

            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            if (CompareTag("Quest"))
                { 
            if ((FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished == false))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1 = new weapon("Pocket Knife", 4, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1 = new weapon("Knuckle Duster", 5, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1 = new weapon("Empty Pistol", 3, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1 = new weapon("Beer bottle", 2, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1 = new armor("Rags", 0, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1 = new armor("Duster", 1, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1 = new armor("Ranger Uniform", 3, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1 = new armor("Gunslinger Outfit", 2, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.quest1Triggered = true;
                    GameObject sceneManager = GameObject.Find("SceneManager");

                    if (sceneManager != null)
                    {
                        sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
                    }

                }
            }
            if (CompareTag("Quest2"))
            {
                if ((FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished == true && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished == false))
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1.Equip = false; 
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1.Equip = false;

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1.Equip = false;
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1.Equip = false;


                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2 = new weapon("Dynamite", 9, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2 = new weapon("Repeater", 7, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2 = new weapon("Big iron", 13, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2 = new weapon("Molotov Cocktail", 14, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2 = new armor("Leather", 4, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2 = new armor("Sherrif outfit", 6, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2 = new armor("Texas Red outfit", 7, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2 = new armor("Evil Gunslinger Outfit", 5, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.quest2Triggered = true;
                    GameObject sceneManager = GameObject.Find("SceneManager");

                    if (sceneManager != null)
                    {
                        sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
                    }
                }
            }
            if (CompareTag("Quest3"))
            {
                if ((FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished == true && FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished == false))
                {
                


                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3 = new weapon("Stack of Dynamite", 13, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3 = new weapon("Hunting rifle", 15, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3 = new weapon("Bigger iron", 17, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3 = new weapon("Molotov Cocktail with oil", 16, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3 = new armor("Bull Leather", 8, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3 = new armor("Elite Sherrif outfit", 11, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3 = new armor("The Stranger Gear", 13, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3 = new armor("Bandit leader Outfit", 10, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered = true;
                    GameObject sceneManager = GameObject.Find("SceneManager");

                    if (sceneManager != null)
                    {
                        sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
                    }

                }
            }
        }

    }


}
