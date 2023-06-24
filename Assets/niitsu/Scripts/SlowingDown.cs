using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingDown : ItemScript
{
    [Header("遅い状態の速度")] public float Speed = 1;
    [Header("遅い状態を維持する時間")] public float Time = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {

        yield return new WaitForSeconds(Time);

        // アイテムを消滅
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
