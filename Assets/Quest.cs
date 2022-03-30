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
        if (FindObjectOfType<PlayerAndGameInfo>().infos.questFinished)
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(false);
            this.transform.GetChild(2).gameObject.SetActive(false);
            this.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            if ((FindObjectOfType<PlayerAndGameInfo>().infos.questFinished == false))
            {
                FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1 = new weapon("Pocket Knife", 4, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1 = new weapon("Knuckle Duster", 5, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1 = new weapon("Empty Pistol", 3, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1 = new weapon("Beer bottle", 2, true);

                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1 = new armor("Rags", 0, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1 = new armor("Duster", 1, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1 = new armor("Ranger Uniform", 3, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1 = new armor("Gunslinger Outfit", 2, true);
                FindObjectOfType<PlayerAndGameInfo>().infos.questTriggered = true;
                GameObject sceneManager = GameObject.Find("SceneManager");

                if (sceneManager != null)
                {
                    sceneManager.GetComponent<ScreenSystem>().GoToCombatScene();
                }

            }

         

        }

    }


}
