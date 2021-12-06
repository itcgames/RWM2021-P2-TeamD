using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class CheckpointSystem : MonoBehaviour
{

    [System.Serializable]
    public struct SavaData<t>
    {
        public string name;
        public t data;
    }

    //save file location
    public string filename;

    //player data lists
    public List<SavaData<int>> playerDataInt;

    public List<SavaData<int>> gameDataInt;

    public void Awake()
    {
        filename = Application.dataPath + "playerData.json";
        playerDataInt = new List<SavaData<int>>();
        gameDataInt = new List<SavaData<int>>();
    }

    public string fileLoc()
    {
        return filename;
    }

    public void AddPlayerData<T>(string t_string, T t_data)
    {
        //All player int data needed
        if(t_data is int)
        {
            SavaData<int> data;
            data.name = t_string;
            data.data = (int)Convert.ChangeType(t_data, typeof(int));
            playerDataInt.Add(data);
        }
    }

    public void AddGameData<T>(string t_string, T t_data)
    {
        //All player int data needed
        if (t_data is int)
        {
            SavaData<int> data;
            data.name = t_string;
            data.data = (int)Convert.ChangeType(t_data, typeof(int));
            gameDataInt.Add(data);
        }
    }

    public void SaveData()
    {
        TextWriter tw;
        if (!File.Exists(filename))
        {
            tw = new StreamWriter(filename, false);
            tw.Close();
        }
        tw = new StreamWriter(filename, true);

        if (playerDataInt != null)
        {
            tw.WriteLine("Int Player Data \n");
            for (int i = 0; i < playerDataInt.Count; i++)
            {
                tw.WriteLine(playerDataInt[i].name + " , " + playerDataInt[i].data);
            }
        }

        if (gameDataInt != null)
        {
            tw.WriteLine("\nInt Game Data\n");
            for (int i = 0; i < gameDataInt.Count; i++)
            {
                tw.WriteLine(gameDataInt[i].name + " , " + gameDataInt[i].data);
            }
        }

        tw.Close();
    }

    public void SaveData(string s)
    {
        File.WriteAllText(filename, s);
    }

    public string LoadData()
    {
        string s = File.ReadAllText(filename);
        return s;
    }
}
