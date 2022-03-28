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
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon1_1 = new weapon("Pocket Knife", 4, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon2_1 = new weapon("Knuckle Duster", 5, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon3_1 = new weapon("Empty Pistol", 3, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_weapon4_1 = new weapon("Beer bottle", 2, false);

            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor1_1 = new armor("Rags", 0, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor2_1 = new armor("Duster", 1, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor3_1 = new armor("Ranger Uniform", 3, false);
            FindObjectOfType<PlayerAndGameInfo>().infos.m_armor4_1 = new armor("Gunslinger Outfit", 2, false);
            this.enabled = false;
        
    }
}
