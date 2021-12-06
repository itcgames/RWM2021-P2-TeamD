﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharNameAndImg : MonoBehaviour
{
    public List<Sprite> images;
    public List<string> names;
    int listPos;
    public List<string> partyTypes;

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
        if(partyTypes[listPos] == PartyType.B_Mage.ToString())
        {
            return PartyUtil.SetupMage("HP");
        }
        else if (partyTypes[listPos] == PartyType.BL_Belt.ToString())
        {
            return PartyUtil.SetupBlackBelt("HP");
        }
        else if (partyTypes[listPos] == PartyType.Fighter.ToString())
        {
            return PartyUtil.SetupFighter("HP");
        }
        else if (partyTypes[listPos] == PartyType.Thief.ToString())
        {
            return PartyUtil.SetupThief("HP");
        }
        return null;
    }
    public Attribute GetAttribute2()
    {
        if (partyTypes[listPos] == PartyType.B_Mage.ToString())
        {
            return PartyUtil.SetupMage("DMG");
        }
        else if (partyTypes[listPos] == PartyType.BL_Belt.ToString())
        {
            return PartyUtil.SetupBlackBelt("DMG");
        }
        else if (partyTypes[listPos] == PartyType.Fighter.ToString())
        {
            return PartyUtil.SetupFighter("DMG");
        }
        else if (partyTypes[listPos] == PartyType.Thief.ToString())
        {
            return PartyUtil.SetupThief("DMG");
        }
        return null;
    }



}
