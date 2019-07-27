using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadDevice("None"));
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Cambiar a elige una escena
    public void DoOnPlayClick()
    {
        SceneManager.LoadScene("ForestScene");
    }

    public void DoOnQuickClick()
    {
        Application.Quit();
    }

    //Change device view mode
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
