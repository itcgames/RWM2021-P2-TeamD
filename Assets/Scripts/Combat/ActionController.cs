using System.Collections;
using UnityEngine;
using UnityEngine.UI;

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
    public Text StatusTxt;

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
        if (Target != null)
        {
            if (Target.GetComponent<CharacterAttributes>().FindAttribute("Def") != null)
            {
                int emotionalDamage = ((int)(GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value / 100 * Target.GetComponent<CharacterAttributes>().FindAttribute("Def").Value));
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -= (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value -
                 emotionalDamage);

                StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value -
                 emotionalDamage) + " TO "
                + Target.GetComponent<CharacterAttributes>().Name;
            }
            else
            {
                if (GetComponent<CharacterAttributes>().FindAttribute("Ack") != null)
                {
                    Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -=
                    GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + GetComponent<CharacterAttributes>().FindAttribute("Ack").Value;

                    StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + GetComponent<CharacterAttributes>().FindAttribute("Ack").Value) + " TO "
                + Target.GetComponent<CharacterAttributes>().Name;
                }
                else
                {
                    Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -=
                        GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;

                    StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + " TO "
                + Target.GetComponent<CharacterAttributes>().Name;
                }
            }

            Debug.Log(GetComponent<CharacterAttributes>().Name + " Dealt " + GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value +
                   " to " + Target.GetComponent<CharacterAttributes>().Name);

            if (Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value <= 0.0f)
            {
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value = 0.0f;
                Debug.Log(Target.GetComponent<CharacterAttributes>().Name + " Defeated");
                Target.SetActive(false);
            }
        }

        Action = CombatAction.None;
    }

    private void Flee()
    {
        int success = Random.Range(1, 101);

        if (success > 50)
        {
            Debug.Log("Successfully escaped!");
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Escape;
        }

        else
        {
            Debug.Log("failed to escape...");
        }
    }
}
