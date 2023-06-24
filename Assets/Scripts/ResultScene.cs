using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickReTryGameButton()
    {
        Initiate.Fade("GameScene", fadeColor, fadeSpeedMultiplier);
    }

    public void OnClickBackTheTitleButton()
    {
        Initiate.Fade("Title", fadeColor, fadeSpeedMultiplier);

    }
}
