using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ARNavigationPanel : MonoBehaviour
{
    /// <summary>
    /// 층수 정보
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _floorText;

    /// <summary>
    /// 뒤로가기 버튼 - QR 스캔 창으로 이동
    /// </summary>
    [SerializeField]
    private Button _backBtn;

    /// <summary>
    /// 세부장소 드롭다운 - NavigationData에서 가져올 것
    /// </summary>
    private TMP_Dropdown _destinationDropDown;

    private void Start()
    {
        _backBtn.onClick.AddListener(NavigationData.instance.OpenQRScanPanel);
    }

    private void OnEnable()
    {
        // 층정보 띄워주기
        _floorText.text = $"{((int)NavigationData.instance.Floor).ToString()}F";
        _destinationDropDown = NavigationData.instance.DestinationDropDown;
        SetNavigationTargetDropDownOptions();
    }

    /// <summary>
    /// 드롭다운에 해당 층의 옵션 세팅해주기
    /// 옵션데이터의 string 값과 SetNavigationTarget.cs에서 타겟 오브젝트 리스트에 넣어주고 있는 Name이랑 일치해야 함.
    /// </summary>
    private void SetNavigationTargetDropDownOptions()
    {
        int floorNumber = (int)NavigationData.instance.Floor;
        _destinationDropDown.ClearOptions();
        _destinationDropDown.value = 0;

        /*if (line.enabled)
        {
            ToggleVisibility();
        }*/

        /* if (floorNumber == 10)
         {
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube10119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube10117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube10120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube10108"));

         }
         if (floorNumber == 9)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube9119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube9117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube9120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube9108"));
         }
         if (floorNumber == 8)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube8119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube8117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube8120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube8108"));
         }
         if (floorNumber == 7)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube7119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube7117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube7120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube7108"));
         }
         if (floorNumber == 6)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube6119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube6117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube6120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube6210"));
         }
         if (floorNumber == 5)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube5119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube5117"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube5120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube5205"));
         }
         if (floorNumber == 4)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube4218"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube4123"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube4205"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube4228"));
         }
         if (floorNumber == 3)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube3120"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube3108"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube3203"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube3228"));
         }
         if (floorNumber == 2)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube2119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube2204"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube2104-2"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube2228"));
         }
         if (floorNumber == 1)
         {

             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube1119"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube1225"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCubeESpace"));
             _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("TargetCube1006-3"));
         }*/

        if (floorNumber == 10)
        {
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("10119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("10117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("10120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("10108"));

        }
        if (floorNumber == 9)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("9119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("9117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("9120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("9108"));
        }
        if (floorNumber == 8)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("8119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("8117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("8120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("8108"));
        }
        if (floorNumber == 7)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("7119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("7117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("7120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("7108"));
        }
        if (floorNumber == 6)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("6119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("6117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("6120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("6210"));
        }
        if (floorNumber == 5)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("5119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("5117"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("5120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("5205"));
        }
        if (floorNumber == 4)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("4218"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("4123"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("4205"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("4228"));
        }
        if (floorNumber == 3)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("3120"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("3108"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("3203"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("3228"));
        }
        if (floorNumber == 2)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("2119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("2204"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("2104-2"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("2228"));
        }
        if (floorNumber == 1)
        {

            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("1119"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("1225"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("ESpace"));
            _destinationDropDown.options.Add(new TMP_Dropdown.OptionData("1006-3"));
        }

        _destinationDropDown.captionText.text = _destinationDropDown.options[0].text;
    }
}
