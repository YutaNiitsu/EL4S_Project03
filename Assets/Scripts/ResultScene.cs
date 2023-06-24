using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 10.0f;
    ClickSE click;
    private int winlose;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;



    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        lose.SetActive(false);

        click = this.GetComponent<ClickSE>();
        //click.PlaySE(1);
        //click.PlaySE(2);
        winlose = Player.GetPlayerRank();
        //winlose = 2;
        if (winlose == 2)
        {
            click.PlaySE(1);
            win.SetActive(true);
        }
        else
        {
            click.PlaySE(2);
            lose.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickReTryGameButton()
    {
        click.PlaySE(0);
        Initiate.Fade("GameScene", fadeColor, fadeSpeedMultiplier);
    }

    public void OnClickBackTheTitleButton()
    {
        click.PlaySE(0);
        Initiate.Fade("Title", fadeColor, fadeSpeedMultiplier);
    }
}
