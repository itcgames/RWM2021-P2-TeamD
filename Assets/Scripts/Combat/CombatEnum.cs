public class CombatEnum
{
    public enum CombatState
    {
        Inactive,
        Start,
        ActionSelect,
        Battle,
        Victory,
        Failure,
        Escape,
    }

    public static CombatState s_currentCombatState = CombatState.Inactive;

    public static bool s_advantage = true;
}
