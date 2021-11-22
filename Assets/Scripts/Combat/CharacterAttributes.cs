using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttributes : MonoBehaviour
{
    [SerializeField]
    private string m_name;

    [SerializeField]
    private bool m_playable;

    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }
    
    public bool Playable
    {
        get { return m_playable; }
        set { m_playable = value; }
    }

    private int m_gil;
    private int m_xp;

    public int Gil
    {
        get { return m_gil; }
        set { m_gil = value; }
    }

    public int Xp
    {
        get { return m_xp; }
        set { m_xp = value; }
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

    public void RemoveAttribute(string name)
    {
        Attribute toRemove = m_attributes.Find(attribute => attribute.Name == name);
        m_attributes.Remove(toRemove);
    }

    public void ClearAttributes()
    {
        m_attributes.Clear();
    }
}