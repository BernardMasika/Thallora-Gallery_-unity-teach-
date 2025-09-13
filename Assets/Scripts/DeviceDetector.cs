using UnityEngine;

public class DeviceDetector : MonoBehaviour
{
    [SerializeField] private GameObject uiPC;

    [SerializeField] private GameObject uiMobile;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DetectDevice();
    }

    private void DetectDevice()
    {
        if (Application.isEditor)
        {
            uiPC.SetActive(true);
            uiMobile.SetActive(false);
        } 
        else if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            uiPC.SetActive(true);
            uiMobile.SetActive(false);
        } 
        else if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            uiMobile.SetActive(true);
            uiPC.SetActive(false);
        }
    }
}
