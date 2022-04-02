using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Linq;
using UnityEngine.UI;

public class CheckpointSystem : MonoBehaviour
{

    [System.Serializable]
    public class MyList<T>
    {
        public List<string> name = new List<string>();

        public List<T> data = new List<T>();
    }

    [System.Serializable]
    public class Info
    {
        public MyList<int> intList = new MyList<int>();
        public MyList<float> floatList = new MyList<float>();
        public MyList<string> stringList = new MyList<string>();
        public MyList<Vector2> vector2List = new MyList<Vector2>();
    }

    //save file location
    string filename;
    public Info info;
    ArrayList arrayList = new ArrayList();
    List<string> fileLines;
    bool autoSaveEnabled = true;

    float autoSaveInterval = 10.0f;
    float autoSaveTimeLeft;
    public bool autoSave = false;
    public int timesSaved = 0;

    bool missionHappening;
    int taskSaveInterval = 0;
    int currentTaskNum = 0;
    int tasksFinished = 0;
    int missionTaskNum = 0;
    public int missionTimeSaved = 0;

    public Text missionText;
    string missionObjective;

    public void Awake()
    {
        filename = Application.dataPath + "playerData.txt";
        info = new Info();
        fileLines = new List<string>();

        arrayList.Add(info.intList);
        arrayList.Add(info.floatList);
        arrayList.Add(info.stringList);
        arrayList.Add(info.vector2List);
    }

    public void Start()
    {
        autoSaveTimeLeft = autoSaveInterval;
    }

    void Update()
    {
        if(autoSaveEnabled)
        {
            AutoSave();
        }

        if (missionHappening)
        {
            MissionSave();
        }
    }

    public string fileLoc()
    {
        return filename;
    }

    public void AddToIntList(string s, int data)
    {
        info.intList.name.Add(s);
        info.intList.data.Add(data);        
    }

    public void AddToFloatList(string s, float data)
    {
        info.floatList.name.Add(s);
        info.floatList.data.Add(data);
    }

    public void AddToStringList(string s, string data)
    {
        info.stringList.name.Add(s);
        info.stringList.data.Add(data);
    }

    public void AddToVector2List(string s, Vector2 data)
    {
        info.vector2List.name.Add(s);
        info.vector2List.data.Add(data);
    }

    public void SaveDataToFile()
    {
        TextWriter tw;
        if (!File.Exists(filename))
        {
            
            tw = new StreamWriter(filename, false);
            tw.Close();
        }
        tw = new StreamWriter(filename, false);

        foreach(var i in arrayList)
        {
            tw.WriteLine(JsonUtility.ToJson(i));
        }

        tw.Close();
    }

    public void LoadData()
    {
        fileLines = File.ReadAllLines(filename).ToList();

        int i = 0;
        foreach(string s in fileLines)
        {
            JsonUtility.FromJsonOverwrite(s, arrayList[i]);
            i++;
        }
    }

    public void SetSaveTimeInterval(int mins)
    {
        autoSaveInterval = (mins * 60);
    }

    public void EnableAutoSave(bool enable)
    {
        autoSaveEnabled = enable;
    }

    void AutoSave()
    {
        if (autoSaveTimeLeft > 0.0f)
        {
            autoSaveTimeLeft -= Time.deltaTime;
            autoSave = false;
        }
        else
        {
            autoSaveTimeLeft = autoSaveInterval;
            autoSave = true;
            timesSaved++;
            SaveDataToFile();
        }
    }

    public void MissionInProgress(bool enable)
    {
        missionHappening = enable;
        missionText.gameObject.SetActive(true);
        UpdateMissionText();
    }

    public void TaskSaveInterval(int taskNum)
    {
        taskSaveInterval = taskNum;
    }

    public void IncrementCurrentTaskNum()
    {
        currentTaskNum++;
        tasksFinished++;
        UpdateMissionText();
    }

    public void MissionTaskNum(int taskNum)
    {
        missionTaskNum = taskNum;
    }

    void MissionSave()
    {
        if (currentTaskNum == taskSaveInterval)
        {
            SaveDataToFile();
            currentTaskNum = 0;
            UpdateMissionText();
            missionTimeSaved++;
        }
        if (tasksFinished >= missionTaskNum)
        {
            SaveDataToFile();
            currentTaskNum = 0;
            tasksFinished = 0;
            MissionInProgress(false);
            UpdateMissionText();
            missionText.gameObject.SetActive(false);
            missionTimeSaved++;
        }
    }

    public void SetMissionText(string t_str)
    {
        missionObjective = t_str;
    }

    void UpdateMissionText()
    {
        missionText.text = missionObjective + " Tasks till next save: " + (taskSaveInterval - currentTaskNum).ToString();
    }
}
