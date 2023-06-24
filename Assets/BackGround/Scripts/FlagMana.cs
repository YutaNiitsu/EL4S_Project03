using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMana : MonoBehaviour
{
    [SerializeField][Tooltip("スタート地点の旗かどうか")] private bool isStartFlag;
    [SerializeField] [Tooltip("スタートマネージャー")] private StartMana StartMana;
    [SerializeField] [Tooltip("ゴールマネージャー")] private GoalMana goalMana;
    [SerializeField] [Tooltip("移動量")]private float MoveAmount=10;
    [SerializeField] private float offsetTime;
    private Vector3 startpos;
    private Vector3 pos; // 現在のSphereの位置
    private float n; // カーブの横軸の値
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        StartCoroutine(Delay());
    }
    private void Update()
    {
        
    }

    IEnumerator Delay()
    {
        float time = StartMana.Delay;
        if(!isStartFlag)
        {
            time = goalMana.MaXTime+ offsetTime;
        }
        yield return new WaitForSeconds(time);
        StartCoroutine(MoveSphere());
    }

    IEnumerator MoveSphere()
    {
        while (true)
        {
            pos = transform.position;
            pos.x = n * -MoveAmount + startpos.x; 
            transform.position = pos;
            n += 0.01f;

            yield return new WaitForSeconds(0.01f);

            if (n > 1) yield break;
        }
    }
}
