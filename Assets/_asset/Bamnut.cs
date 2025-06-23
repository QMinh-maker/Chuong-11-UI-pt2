using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Bamnut : MonoBehaviour
{
    public GameObject RateMenu;
    public GameObject LevelCompMenu;
    public GameObject Level2Menu;
    public GameObject RewardMenu;   
    public GameObject SettingMenu;
    

    public void OnGreatButton()
    {
        RateMenu.SetActive(false);
        LevelCompMenu.SetActive(true);
    }

    public void OnLaterButton()
    {
        RateMenu.SetActive(false);
        Level2Menu.SetActive(true);
    }

    public void OnClaimButton()
    {
        
        LevelCompMenu.SetActive(false);
        RewardMenu.SetActive(true);
    }

    public void OnGrayCollectButton() 
    {
        LevelCompMenu.SetActive(true);
        RewardMenu.SetActive(false);
    }

    public void OnGreenCollectButton()
    {
        SettingMenu.SetActive(true);
        RewardMenu.SetActive(false);
    }

    public void OnSettingButton() 
    {
        RewardMenu.SetActive(true);
        SettingMenu.SetActive(false);
    }
    public void OnResumeMenuButton()
    {
        SettingMenu.SetActive(false);
        Level2Menu.SetActive(true);
    }

    public void OnPlayButton()
    {
        Level2Menu.SetActive(false);
        SettingMenu.SetActive(true);
    }

    public void OnXButton()
    {
        RewardMenu.SetActive(false);
        SettingMenu.SetActive(false);
        RateMenu.SetActive(true);
    }
}
