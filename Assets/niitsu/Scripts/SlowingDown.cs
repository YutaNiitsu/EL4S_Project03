using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingDown : ItemScript
{
    [Header("遅い状態の速度")] public float Speed = 1;
    [Header("遅い状態を維持する時間")] public float Time = 5;
   
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(Speed);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        // アイテムを消滅
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
