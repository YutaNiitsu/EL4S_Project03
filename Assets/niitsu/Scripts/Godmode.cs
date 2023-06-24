using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Godmode : ItemScript
{
    [Header("–³“Gó‘Ô‚ÌŠÔ")] public float Time = 5;
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

        yield return new WaitForSeconds(Time);

        // ƒAƒCƒeƒ€‚ğÁ–Å
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
