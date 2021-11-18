using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStrikeChance : MonoBehaviour
{
    public enum CheckType
    {
        BooleanExpressions,
        Random,
        RandomInfluencedByAnATTR
    }

    [SerializeField]
    private CheckType m_type;

    [SerializeField]
    private bool m_onAdvantage;

    [SerializeField]
    private Attribute m_attribute;

    [SerializeField]
    private float m_successThreshold = 80.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetType(CheckType type)
    {
        m_type = type;
    }

    public void SetOnAdvantage(bool cond)
    {
        m_onAdvantage = cond;
    }

    public void SetAttribute(string name, float val)
    {
        m_attribute.Name = name;
        m_attribute.Value = val;
    }

    public bool FirstStrikeCheck()
    {
        switch(m_type)
        {
            case CheckType.BooleanExpressions:
                return m_onAdvantage == true;
            case CheckType.Random:
                return Random.Range(1.0f, 100.0f) > m_successThreshold;
            case CheckType.RandomInfluencedByAnATTR:
                return Random.Range(1.0f, 100.0f) > m_successThreshold - (m_attribute.Value / 2.0f);
            default:
                return false;
        }
    }

    public bool FirstStrikeCheckTestVer(float randVal)
    {
        switch (m_type)
        {
            case CheckType.BooleanExpressions:
                return m_onAdvantage == true;
            case CheckType.Random:
                return randVal > m_successThreshold;
            case CheckType.RandomInfluencedByAnATTR:
                return randVal > m_successThreshold - (m_attribute.Value / 2.0f);
            default:
                return false;
        }
    }
}
