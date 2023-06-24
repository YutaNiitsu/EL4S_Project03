using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godmode : ItemScript
{
    [Header("���G��Ԃ̎���")] public float Time = 5;
    
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetGodFlag(true);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetGodFlag(false);
        // �A�C�e��������
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
