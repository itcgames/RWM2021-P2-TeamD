using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameState
{
    public int id;
}

[System.Serializable]
public class CombatData : GameState
{
    public int onAdvantage;
    public int enemyCount;
    public int turnTotal;
    public int victory;
}

public class ActionsData : GameState
{
    public int damageDealt;
    public int damageTaken;
}

public class EndpointData : GameState
{
    public int endpointReached;
    public float timeToReachEndpoint;
}

public class TavernData : GameState
{
    public int tavernMinigameWon;
    public int missPressedKeys;
}

public class EquipmentData : GameState
{
    public int weaponsEquipped;
    public int weaponsUpgradedCount;
    public int armourEquipped;
    public int totalGearDropped;
    public int goldSpentOnUpgrades;
}

public class ItemsData : GameState
{
    public int itemsBought;
    public int itemsSold;
}

public class QuestData : GameState
{
    public int questsCleared;
}

public class DataCollectionUtility : MonoBehaviour
{
    // monobehaviour passed in since you need an object to run a coroutine.
    // just pass in "this" keywork when calling the func()
    public static void PostData(GameState data, MonoBehaviour toRunCoroutine)
    {
        string jsonData = JsonUtility.ToJson(data);

        toRunCoroutine.StartCoroutine(AnalyticsManager.PostMethod(jsonData));
    }
}
