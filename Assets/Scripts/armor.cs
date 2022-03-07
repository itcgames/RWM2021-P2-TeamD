using UnityEngine;

[System.Serializable]
public class armor
{
    [SerializeField]
    private string m_name;

    [SerializeField]
    private float m_value;

    public armor(string name, float value)
    {
        m_name = name;
        m_value = value;
    }

    public float Value
    {
        get { return m_value; }
        set { m_value = value; }
    }

    public string Name
    {
        get { return m_name; }
        set { m_name = value; }
    }
}

