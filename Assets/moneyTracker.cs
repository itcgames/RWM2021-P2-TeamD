using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyTracker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.GetChild(0).GetComponent<Text>().text = "Gil: " + FindObjectOfType<PlayerAndGameInfo>().infos.m_gil.ToString();
    }
}
