using UnityEngine;

public class ActionController : MonoBehaviour
{
    public enum CombatAction
    {
        None,
        Fight,
        Flee,
        Magic,
        Drink,
        Item
    }

    private GameObject m_target;

    public CombatAction Action { get; set; } = CombatAction.None;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExecuteAction()
    {
        switch (Action)
        {
            case CombatAction.None:
                break;
            case CombatAction.Fight:
                Fight();
                break;
            case CombatAction.Flee:
                Flee();
                break;
            case CombatAction.Magic:
                break;
            case CombatAction.Drink:
                break;
            case CombatAction.Item:
                break;
            default:
                break;
        }
    }

    private void Fight()
    {
        m_target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -= GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;
    }

    private void Flee()
    {
        int success = Random.Range(1, 101);

        if (success > 50) Debug.Log("Successfully escaped!");
        else Debug.Log("failed to escape...");
    }
}
