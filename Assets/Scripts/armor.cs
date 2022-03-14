﻿using UnityEngine;

[System.Serializable]
public class armor
{
    [SerializeField]
    private string m_name;

    [SerializeField]
    private float m_value;

    [SerializeField]
    private bool m_equipped;

    public armor(string name, float value, bool equipped)
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

        if(equipped && !this.m_name.StartsWith("E:"))
        {
            this.m_name = "E:" + m_name;
        }
        else
        {
            if(this.m_name.StartsWith("E:"))
            {
                this.m_name.Remove(0);
                this.m_name.Remove(1);

            }
        }
    }
}


