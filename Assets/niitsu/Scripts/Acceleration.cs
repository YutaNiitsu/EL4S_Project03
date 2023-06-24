using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : ItemScript
{
    [Header("速い状態の速度")] public float Speed = 5;
    [Header("速い状態を維持する時間")] public float Time = 5;
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
        PlayerScriptRef.SetSpeed(Speed);
        yield return new WaitForSeconds(Time);
        PlayerScriptRef.SetDefaultSpeed();
        // アイテムを消滅
        Destroy(this.gameObject);
    }
}
