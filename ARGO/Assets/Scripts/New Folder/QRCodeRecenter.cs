using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using ZXing;

public class QRCodeRecenter : MonoBehaviour
{
    [SerializeField]
    private ARSession session;
    [SerializeField]
    private ARSessionOrigin sessionOrigin;
    [SerializeField]
    private ARCameraManager cameraManager;
    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();


    /// <summary>
    /// Test용 - 에디터상에서 QR데이터를 string값으로 임의로 넣어주기
    /// Test시에만 이용하고 아닐시에 끄기
    /// </summary>
    [SerializeField]
    private TMP_InputField inputFieldTest;
    [SerializeField]
    private Button testBtn;


    private Texture2D cameraImageTexture;
    private IBarcodeReader reader = new BarcodeReader();

    private void Start()
    {
        testBtn.onClick.AddListener(ChangeActiveFloor);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetQrCodeRecenterTarget("TargetCube10119");
        }
    }

    private void OnEnable()
    {
        cameraManager.frameReceived += OnCameraFrameReceived;
    }

    private void OnDisable()
    {
        cameraManager.frameReceived -= OnCameraFrameReceived;
    }

    private void OnCameraFrameReceived(ARCameraFrameEventArgs eventArgs)
    {
        if (!cameraManager.TryAcquireLatestCpuImage(out XRCpuImage image))
        {
            return;
        }


        var conversionParams = new XRCpuImage.ConversionParams
        {
            // Get the entire image.
            inputRect = new RectInt(0, 0, image.width, image.height),
            // Downsample by 2.
            outputDimensions = new Vector2Int(image.width / 2, image.height / 2),
            // Choose RGBA format.
            outputFormat = TextureFormat.RGBA32,
            // Flip across the vertical axis (mirror).
            transformation = XRCpuImage.Transformation.MirrorY
        };

        int size = image.GetConvertedDataSize(conversionParams);

        var buffer = new NativeArray<byte>(size, Allocator.Temp);

        image.Convert(conversionParams, buffer);

        image.Dispose();

        cameraImageTexture = new Texture2D(
            conversionParams.outputDimensions.x,
            conversionParams.outputDimensions.y,
            conversionParams.outputFormat,
            false);

        cameraImageTexture.LoadRawTextureData(buffer);
        cameraImageTexture.Apply();

        buffer.Dispose();

        var result = reader.Decode(cameraImageTexture.GetPixels32(), cameraImageTexture.width, cameraImageTexture.height);

        if (result != null)
        {
            SetQrCodeRecenterTarget(result.Text);
        }
    }

    private void SetQrCodeRecenterTarget(string targetText)
    {
        // 받아온 targetText를 enum 값으로 바꿔주기
        switch(targetText)
        {
            case "TenFloor":
                NavigationData.instance.Floor = Floor.Tenth;
                break;
            case "NineFloor":
                NavigationData.instance.Floor = Floor.Ninth;
                break;
            case "EightFloor":
                NavigationData.instance.Floor = Floor.Eighth;
                break;
            case "SevenFloor":
                NavigationData.instance.Floor = Floor.Seventh;
                break;
            case "SixFloor":
                NavigationData.instance.Floor = Floor.Sixth;
                break;
            case "FiveFloor":
                NavigationData.instance.Floor = Floor.Fifth;
                break;
            case "FourFloor":
                NavigationData.instance.Floor = Floor.Forth;
                break;
            case "ThirdFloor":
                NavigationData.instance.Floor = Floor.Third;
                break;
            case "SecondFloor":
                NavigationData.instance.Floor = Floor.Second;
                break;
            case "FirstFloor":
                NavigationData.instance.Floor = Floor.First;
                break;
        }

        Target currentTarget = navigationTargetObjects.Find(x => x.Name.ToLower().Equals(targetText.ToLower()));
        if (currentTarget != null)
        {
            session.Reset();

            sessionOrigin.transform.position = currentTarget.PositionObject.transform.position;
            sessionOrigin.transform.rotation = currentTarget.PositionObject.transform.rotation;
        }

        NavigationData.instance.OpenARNavigationPanel();
    }

    /// <summary>
    /// 현재는 Test용으로 Input Field에서 입력했을때만 이용하고 있음.
    /// </summary>
    public void ChangeActiveFloor()
    {
        string floorEntrance = inputFieldTest.text;
        SetQrCodeRecenterTarget(floorEntrance);
    }
}