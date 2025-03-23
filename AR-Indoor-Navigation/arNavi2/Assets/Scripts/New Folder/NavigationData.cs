using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Ãþ Á¤º¸
public enum Floor
{
    First = 1,
    Second = 2,
    Third = 3,
    Forth = 4,
    Fifth = 5,
    Sixth = 6,
    Seventh = 7,
    Eighth = 8,
    Ninth = 9,
    Tenth = 10,
}

public class NavigationData : Singleton<NavigationData>
{
    /// <summary>
    /// Ãþ
    /// </summary>
    [SerializeField]
    private Floor _floor;
    public Floor Floor { get { return _floor; } set { _floor = value; } }


    /// <summary>
    /// µå·Ó´Ù¿î
    /// </summary>
    [SerializeField]
    private TMP_Dropdown _destinationDropDown;
    public TMP_Dropdown DestinationDropDown { get { return _destinationDropDown; } }

    /// <summary>
    /// ÆÇ³Ú¿ÀºêÁ§Æ®
    /// </summary>
    [SerializeField]
    private GameObject _qrScanPanel;
    [SerializeField]
    private GameObject _arNavigationPanel;
    [SerializeField]
    private GameObject _qrCodeRecenter;

    private void Start()
    {
        
    }

    /// <summary>
    /// QR½ºÄµ Ã¢ ¶ç¿ï¶§
    /// </summary>
    public void OpenQRScanPanel()
    {
        _qrScanPanel.SetActive(true);
        _arNavigationPanel.SetActive(false);
        _qrCodeRecenter.SetActive(true);
    }

    /// <summary>
    /// ¼¼ºÎ Àå¼Ò ¶ç¿ï¶§
    /// </summary>
    public void OpenARNavigationPanel()
    {
        _qrScanPanel.SetActive(false);
        _arNavigationPanel.SetActive(true);
        _qrCodeRecenter.SetActive(false);
    }
}
