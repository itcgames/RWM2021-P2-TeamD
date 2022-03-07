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
