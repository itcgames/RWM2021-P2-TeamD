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
                StartCoroutine(Fight());
                break;
            case CombatAction.Flee:
                StartCoroutine(Flee());
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
        if (Target != null)
        {


            if (Target.GetComponent<CharacterAttributes>().FindAttribute("Def") != null)
            {

                Debug.Log(GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value);
                int emotionalDamage = ((int)(GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value / 100 * Target.GetComponent<CharacterAttributes>().FindAttribute("Def").Value));
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -= (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value -
                 emotionalDamage);
            }
            else
            {
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -=
                    GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;
            }
            if (Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value <= 0.0f)
            {
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value = 0.0f;
                Target.SetActive(false);
            }
            else
            {
                Debug.Log(GetComponent<CharacterAttributes>().Name + " Dealt " + GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value +
                    " to " + Target.GetComponent<CharacterAttributes>().Name);
            }
            yield return new WaitForSeconds(4);
        }

        Action = CombatAction.None;
    }

    private IEnumerator Flee()
    {
        int success = Random.Range(1, 101);

        if (success > 50)
        {
            Debug.Log("Successfully escaped!");
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Escape;

            yield return new WaitForSeconds(2);
        }

        else
        {
            Debug.Log("failed to escape...");
            yield return new WaitForSeconds(2);
        }

        Action = CombatAction.None;
    }
}
