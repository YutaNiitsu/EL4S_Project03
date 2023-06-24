using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingDown : ItemScript
{
    [Header("�x����Ԃ̑��x")] public float Speed = 1;
    [Header("�x����Ԃ��ێ����鎞��")] public float Time = 5;
   
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetSpeed(Speed);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetDefaultSpeed();
        // �A�C�e��������
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
