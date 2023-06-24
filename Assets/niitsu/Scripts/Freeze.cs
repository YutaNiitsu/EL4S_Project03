using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : ItemScript
{
    [Header("��~����")] public float Time = 5;
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

        yield return new WaitForSeconds(Time);

        // �A�C�e��������
        Destroy(this.gameObject);
        Debug.Log(this.gameObject.name);
    }
}
