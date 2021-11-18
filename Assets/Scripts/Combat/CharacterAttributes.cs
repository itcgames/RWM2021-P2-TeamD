using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttributes : MonoBehaviour
{
    [SerializeField]
    private string m_name;

    [SerializeField]
    private bool m_playable;

    public bool Playable
    {
        get { return m_playable; }
        set { m_playable = value; }
    }

    [SerializeField]
    private List<Attribute> m_attributes;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetAttribute(string name, float value)
    {

        int found = m_attributes.FindIndex(attribute => attribute.Name == name);

        if (found != -1)
        {
            m_attributes[found].Value = value;
        }
    }

    public void AddAttribute(Attribute attribute)
    {
        m_attributes.Add(attribute);
    }

    public Attribute FindAttribute(string name)
    {
        return m_attributes.Find(attribute => attribute.Name == name);
    }
}