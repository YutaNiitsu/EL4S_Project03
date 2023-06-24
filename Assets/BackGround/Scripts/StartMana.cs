using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMana : MonoBehaviour
{
    public float Delay = 3.0f;
    [SerializeField][Tooltip("背景のマテリアル選択")] private Material BackGround;
    [SerializeField] [Tooltip("道のマテリアル選択")] private Material Rail;
    [SerializeField] private Player _player;
    [SerializeField] private EnemyPlayer _enemy1;
    [SerializeField] private EnemyPlayer _enemy2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayTime());

    }

    IEnumerator DelayTime()
    {
        StopBackGround();
        yield return new WaitForSeconds(Delay);

        StartBackGround();
        //ここでスタート
        _player.SetIsStart(true);
        _enemy1.SetIsStart(true);
        _enemy2.SetIsStart(true);
    }

    public void StopBackGround()
    {
        BackGround.SetFloat("_isStop", 1.0f);
        Rail.SetFloat("_isStop", 1.0f);
    }

public void StartBackGround()
    {
        BackGround.SetFloat("_isStop", 0.0f);
        Rail.SetFloat("_isStop", 0.0f);
    }
}
