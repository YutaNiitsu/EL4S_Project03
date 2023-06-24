using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingDown : ItemScript
{
    [Header("速度を減らす割合")] public float Ratio = 0.5f;
    [Header("遅い状態を維持する時間")] public float Time = 3;
   
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(Ratio);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        // アイテムを消滅
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
