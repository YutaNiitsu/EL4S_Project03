using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : ItemScript
{
    [Header("速度を増やす割合")] public float Ratio = 1.5f;
    [Header("速い状態を維持する時間")] public float Time = 3;
    
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
