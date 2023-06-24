using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Util;

public class TitleScene : MonoBehaviour
{

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 10.0f;
    ClickSE click;
    //[SerializeField] GameObject settingsWindow;
    //SettingsWindowController settingsWindowController;
    // Start is called before the first frame update
    void Start()
    {
        click = this.GetComponent<ClickSE>();
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
        click.PlaySE(0);
        Initiate.Fade("GameScene", fadeColor, fadeSpeedMultiplier);
    }

    public void OnClickExitButton()
    {
#if UNITY_EDITOR
        click.PlaySE(0);
        UnityEditor.EditorApplication.isPlaying = false;
#else
        click.PlaySE(0);
        Application.Quit();
#endif
    }


}
