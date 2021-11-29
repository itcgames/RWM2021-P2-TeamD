using System.Collections;
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

    public GameObject Target { get; set; }

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

    private IEnumerator Fight()
    {
        Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -= GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;

        yield return new WaitForSeconds(4);
    }

    private IEnumerator Flee()
    {
        int success = Random.Range(1, 101);

        if (success > 50)
        {
            Debug.Log("Successfully escaped!");
            yield return new WaitForSeconds(2);
        }

        else
        {
            Debug.Log("failed to escape...");
            yield return new WaitForSeconds(2);
        }
    }
}
