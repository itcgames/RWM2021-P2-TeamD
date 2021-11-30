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
    }

    public static CombatState s_currentCombatState = CombatState.Inactive;
}
