using UnityEngine;

[System.Serializable]
public class weapon
{
    [SerializeField]
    private string m_name;

    [SerializeField]
    private float m_value;

    [SerializeField]
    private bool m_equipped;

    public weapon(string name, float value, bool equipped)
    {
        m_name = name;
        m_value = value;
        m_equipped = equipped;
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
    public bool Equip
    {
        get { return m_equipped; }
        set { m_equipped = value; }
    }

    public void isEquiped(bool equipped)
    {

        if (equipped && !m_name.StartsWith("E:"))
        {
            m_name = "E:" + m_name;
        }
        else if (!equipped)
        {
            if (m_name.StartsWith("E:"))
            {
                m_name.Remove(0, 2);


            }
        }
    }
}


