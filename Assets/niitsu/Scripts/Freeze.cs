using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : ItemScript
{
    [Header("��~����")] public float Time = 5;
    
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(0.0f);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        // �A�C�e��������
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
