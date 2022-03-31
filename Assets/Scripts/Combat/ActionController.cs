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
        Block
    }

    public GameObject Target { get; set; }
    public Vector2 TargetInitPos;

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
            case CombatAction.Block:
                Block();
                break;
            default:
                break;
        }
    }

    private void Fight()
    {
        if (Target != null)
        {
            if (!Target.activeSelf)
            {
                if (Target.GetComponent<CharacterAttributes>().Playable)
                {
                    GameObject obj;
                    Vector2 newTargetPos;
                    GameObject.Find("CombatSystem").GetComponent<CombatController>().GetNewPartyTarget(out obj, out newTargetPos);

                    if (obj != null)
                    {
                        Target = obj;
                        TargetInitPos = newTargetPos;
                    }
                }
                else
                {
                    GameObject obj;
                    Vector2 newTargetPos;
                    GameObject.Find("CombatSystem").GetComponent<CombatController>().GetNewEnemyTarget(out obj, out newTargetPos);

                    if (obj != null)
                    {
                        Target = obj;
                        TargetInitPos = newTargetPos;
                    }
                }
            }

            if (Target.GetComponent<CharacterAttributes>().FindAttribute("Def") != null)
            {
                int emotionalDamage = CalculateDmgReduction(GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value,
                    Target.GetComponent<CharacterAttributes>().FindAttribute("Def").Value,
                    Target.GetComponent<ActionController>().Action == CombatAction.Block);

                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -= (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value -
                 emotionalDamage);

                StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value -
                 emotionalDamage) + " DMG\nTO "
                + Target.GetComponent<CharacterAttributes>().Name;

                StartCoroutine(CameraShake.Shake(0.5f, 0.02f, 1.0f, Target.transform, TargetInitPos));

                //Attack sound
                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PlaySFX("Attack");
                }
            }
            else
            {
                if (GetComponent<CharacterAttributes>().FindAttribute("Ack") != null)
                {
                    Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -=
                    GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + GetComponent<CharacterAttributes>().FindAttribute("Ack").Value;

                    StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + (GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + GetComponent<CharacterAttributes>().FindAttribute("Ack").Value) + " DMG\nTO "
                + Target.GetComponent<CharacterAttributes>().Name;

                    StartCoroutine(CameraShake.Shake(0.5f, 0.02f, 1.0f, Target.transform, TargetInitPos));

                    //Attack sound
                    if (AudioManager.instance != null)
                    {
                        AudioManager.instance.PlaySFX("Attack");
                    }
                }
                else
                {
                    Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value -=
                        GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value;

                    StatusTxt.text = GetComponent<CharacterAttributes>().Name + " DEALS\n"
                + GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value + " DMG\nTO "
                + Target.GetComponent<CharacterAttributes>().Name;

                    StartCoroutine(CameraShake.Shake(0.5f, 0.02f, 1.0f, Target.transform, TargetInitPos));

                    //Attack sound
                    if (AudioManager.instance != null)
                    {
                        AudioManager.instance.PlaySFX("Attack");
                    }
                }
            }

            Debug.Log(GetComponent<CharacterAttributes>().Name + " Dealt " + GetComponent<CharacterAttributes>().FindAttribute("Dmg").Value +
                   " to " + Target.GetComponent<CharacterAttributes>().Name);

            if (Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value <= 0.0f)
            {
                Target.GetComponent<CharacterAttributes>().FindAttribute("HP").Value = 0.0f;
                Debug.Log(Target.GetComponent<CharacterAttributes>().Name + " Defeated");
                Target.SetActive(false);
                //death sound
                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PlaySFX("Death");
                }
            }
        }

        Action = CombatAction.None;
    }

    private void Flee()
    {
        int success = Random.Range(1, 101);

        if (success > 50)
        {
            CombatEnum.s_currentCombatState = CombatEnum.CombatState.Escape;
            //flee sounds
            if (AudioManager.instance != null)
            {
                AudioManager.instance.PauseMusic("BattleTheme");
                AudioManager.instance.PlaySFX("Flee");
                AudioManager.instance.PlayMusic("Theme");
            }
        }

        else
        {
            StatusTxt.text = GetComponent<CharacterAttributes>().Name + " ESCAPE\nATTEMPT FAILED";
        }
    }

    private void Block()
    {
        StatusTxt.text = GetComponent<CharacterAttributes>().Name + "\nIS BLOCKING";
    }

    public static int CalculateDmgReduction(float dmg, float targetDef, bool targetIsBlocking)
    {
        int reduction = 0;

        if (targetIsBlocking)
        {
            reduction = (int)(dmg / 100 * (targetDef * 2));
        }
        else
        {
            reduction = (int)(dmg / 100 * targetDef);
        }

        return reduction;
    }
}
