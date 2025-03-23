using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ARNavigationPanel : MonoBehaviour
{
    /// <summary>
    /// ���� ����
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI _floorText;

    /// <summary>
    /// �ڷΰ��� ��ư - QR ��ĵ â���� �̵�
    /// </summary>
    [SerializeField]
    private Button _backBtn;

    /// <summary>
    /// ������� ��Ӵٿ� - NavigationData���� ������ ��
    /// </summary>
    private TMP_Dropdown _destinationDropDown;

    private void Start()
    {
        _backBtn.onClick.AddListener(NavigationData.instance.OpenQRScanPanel);
    }

    private void OnEnable()
    {
        // ������ ����ֱ�
        _floorText.text = $"{((int)NavigationData.instance.Floor).ToString()}F";
        _destinationDropDown = NavigationData.instance.DestinationDropDown;
        SetNavigationTargetDropDownOptions();
    }

    /// <summary>
    /// ��Ӵٿ �ش� ���� �ɼ� �������ֱ�
    /// �ɼǵ������� string ���� SetNavigationTarget.cs���� Ÿ�� ������Ʈ ����Ʈ�� �־��ְ� �ִ� Name�̶� ��ġ�ؾ� ��.
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
