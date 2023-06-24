using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : ItemScript
{
    [Header("停止時間")] public float Time = 3;
    
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(0.0f);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(2.0f);
        Debug.Log("速度2倍");
        yield return new WaitForSeconds(1.0f);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        Debug.Log("速度戻す");

        // アイテムを消滅
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
