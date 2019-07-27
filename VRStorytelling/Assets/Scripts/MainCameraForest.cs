using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class MainCameraForest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadDevice("Cardboard"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LoadDevice(string newDevice)
    {
        if (String.Compare(XRSettings.loadedDeviceName, newDevice, true) != 0)
        {
            XRSettings.LoadDeviceByName(newDevice);
            yield return null;
            XRSettings.enabled = true;
        }
    }
}
