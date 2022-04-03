using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalAnalytics
{
    public static ActionsData s_actionsData = new ActionsData { damageDealt = 0, damageTaken = 0, id = 1 };
    public static EndpointData s_endPointData = new EndpointData { id = 2, endpointReached = 0, timeToReachEndpoint = 0.0f };
    public static EquipmentData s_equipmentData = new EquipmentData { id = 3, armourEquipped = 0, goldSpentOnUpgrades = 0, totalGearDropped = 0, weaponsEquipped = 0, weaponsUpgradedCount = 0 };
    public static ItemsData s_itemsData = new ItemsData { id = 4, itemsBought = 0, itemsSold = 0 };
    public static QuestData s_questData = new QuestData { id = 5, questsCleared = 0 };
}
