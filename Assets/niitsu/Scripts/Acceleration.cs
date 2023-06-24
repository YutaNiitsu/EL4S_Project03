using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : ItemScript
{
    [Header("���x�𑝂₷����")] public float Ratio = 1.5f;
    [Header("������Ԃ��ێ����鎞��")] public float Time = 3;
    
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(Ratio);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        // �A�C�e��������
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
