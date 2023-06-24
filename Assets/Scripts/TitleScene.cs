using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Util;

public class TitleScene : MonoBehaviour
{

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 10.0f;
    //[SerializeField] GameObject settingsWindow;
    //SettingsWindowController settingsWindowController;
    // Start is called before the first frame update
    void Start()
    {
        //settingsWindowController = settingsWindow.GetComponent<SettingsWindowController>();
        //settingsWindowsPanel = transform.parent.gameObject;

    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton()
    {
        //settingsWindowController.OnClickCloseButton();
        //SceneManager.LoadScene("Game");
        Initiate.Fade("Game", fadeColor, fadeSpeedMultiplier);
    }

    public void OnClickExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


}
