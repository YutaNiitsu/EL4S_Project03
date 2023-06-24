using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godmode : ItemScript
{
    [Header("ñ≥ìGèÛë‘ÇÃéûä‘")] public float Time = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UseItem_Godmode");
    }

    public override void UseItem()
    {
        StartCoroutine("UseItemCoroutine");
    }

    IEnumerator UseItemCoroutine()
    {
        PlayerScriptRef.SetGodFlag(true);
        yield return new WaitForSeconds(Time);
        PlayerScriptRef.SetGodFlag(false);
        // ÉAÉCÉeÉÄÇè¡ñ≈
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
