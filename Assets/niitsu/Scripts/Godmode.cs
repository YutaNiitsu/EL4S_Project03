using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godmode : ItemScript
{
    [Header("–³“Gó‘Ô‚ÌŠÔ")] public float Time = 5;
    
    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        if (PlayerScriptRef != null) PlayerScriptRef.SetGodFlag(true);
        yield return new WaitForSeconds(Time);
        if (PlayerScriptRef != null) PlayerScriptRef.SetGodFlag(false);
        // ƒAƒCƒeƒ€‚ğÁ–Å
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
