using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharNameAndImg : MonoBehaviour
{
    public List<Sprite> images;
    public List<string> names;
    public Attribute attribute1;
    public Attribute attribute2;
    int listPos;

    private void Start()
    {
        listPos = 0;
        this.transform.GetChild(0).GetComponent<Text>().text = names[listPos];
        this.transform.GetChild(1).GetComponent<Image>().sprite = images[listPos];
    }

    public void Next()
    {
        if(listPos < images.Count-1)
        {
            listPos++;
            this.transform.GetChild(0).GetComponent<Text>().text = names[listPos];
            this.transform.GetChild(1).GetComponent<Image>().sprite = images[listPos];
        }
        else
        {
            listPos = 0;
            this.transform.GetChild(0).GetComponent<Text>().text = names[listPos];
            this.transform.GetChild(1).GetComponent<Image>().sprite = images[listPos];
        }
    }

    public void Previous()
    {
        if (listPos > 0)
        {
            listPos--;
            this.transform.GetChild(0).GetComponent<Text>().text = names[listPos];
            this.transform.GetChild(1).GetComponent<Image>().sprite = images[listPos];
        }
        else
        {
            listPos = images.Count-1;
            this.transform.GetChild(0).GetComponent<Text>().text = names[listPos];
            this.transform.GetChild(1).GetComponent<Image>().sprite = images[listPos];
        }
    }

    public Sprite GetImage()
    {
        return images[listPos];
    }

    public string GetName()
    {
        return names[listPos];
    }

    public Attribute GetAttribute1()
    {
        return attribute1;
    }
    public Attribute GetAttribute2()
    {
        return attribute2;
    }
}
