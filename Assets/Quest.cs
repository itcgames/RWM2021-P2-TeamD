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
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished && CompareTag("Quest2"))
        {
            this.GetComponent<Collider2D>().isTrigger = true;
        }

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && CompareTag("Quest2"))
        {

            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.enabled = false;

        }
        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && CompareTag("Quest3"))
        {
            this.GetComponent<Collider2D>().isTrigger = true;
        }

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished && CompareTag("Quest3"))
        {
            

            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.enabled = false;

        }

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest4Finished && CompareTag("Barrier"))
        {

            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.transform.GetChild(3).gameObject.SetActive(false);
            this.transform.GetChild(4).gameObject.SetActive(false);
            this.transform.GetChild(5).gameObject.SetActive(false);
            this.transform.GetChild(6).gameObject.SetActive(false);
            this.transform.GetChild(7).gameObject.SetActive(false);
            this.transform.GetChild(8).gameObject.SetActive(false);
            this.transform.GetChild(9).gameObject.SetActive(false);
            this.transform.GetChild(10).gameObject.SetActive(false);
            this.transform.GetChild(11).gameObject.SetActive(false);
            this.enabled = false;
        }

        if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished && CompareTag("Barrier"))
        {

            this.GetComponent<Collider2D>().isTrigger = true;
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
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1 = new weapon("Hip Crack", 3, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1 = new weapon("Sour", 7, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1 = new weapon("Windows", 5, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1 = new weapon("Plush", 2, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1 = new armor("Socks",1 , false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1 = new armor("Hoodie", 5, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1 = new armor("Big Chest", 5, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1 = new armor("Gura Pin", 1, false);
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
                    


                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_2 = new weapon("Shame Walk", 12, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_2 = new weapon("Jaeger Bomb", 15, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_2 = new weapon("Ubuntu", 16, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_2 = new weapon("Gura Plush", 11, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_2 = new armor("Suit", 11, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_2 = new armor("Gray Hoodie", 20, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_2 = new armor("Polo Shirt", 14, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_2 = new armor("Gura Hat", 15, false);
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
                


                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_3 = new weapon("Penguin", 23, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_3 = new weapon("Tequila", 29, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_3 = new weapon("Linux", 28, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_3 = new weapon("Body Pillow", 26, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_3 = new armor("Penguin Suit", 18, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_3 = new armor("Grey Hoodie", 25, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_3 = new armor("Tavern Jacket", 15, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_3 = new armor("Gura Hoodie", 20, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.quest3Triggered = true;
                    GameObject sceneManager = GameObject.Find("SceneManager");

                    if (sceneManager != null)
                    {
                        sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
                    }

                }
            }
            if (FindObjectOfType<PlayerAndGameInfo>().infos.quest1Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest2Finished && FindObjectOfType<PlayerAndGameInfo>().infos.quest3Finished && CompareTag("Barrier"))
            {
                if (!FindObjectOfType<PlayerAndGameInfo>().infos.quest4Finished)
                {
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_4 = new weapon("War Penguin", 100, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_4 = new weapon("Chateruse", 100, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_4 = new weapon("Arch Linux", 100, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_4 = new weapon("Gura Pillow", 100, false);

                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_4 = new armor("Stopy Amrour", 25, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_4 = new armor("Hoodie Amrour", 50, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_4 = new armor("TOYOTA Amrour", 35, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_4 = new armor("Gura Amrour", 40, false);
                    FindObjectOfType<PlayerAndGameInfo>().infos.quest4Triggered = true;
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
