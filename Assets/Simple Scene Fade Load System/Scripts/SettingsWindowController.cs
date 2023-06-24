using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class SettingsWindowController : MonoBehaviour
{
    GameObject settingsWindowPanel;

    void Start()
    {
        settingsWindowPanel = this.gameObject;
        settingsWindowPanel.SetActive(false);
    }

    public void OpenSettingsWindow()
    {
        settingsWindowPanel.SetActive(true);
    }

    public void OnClickCloseButton()
    {
        settingsWindowPanel.SetActive(true);
        CloseSettingsWindow();
    }

    public void CloseSettingsWindow()
    {
        Fade.FadeoutObject(settingsWindowPanel, 0.3f);
    }
}