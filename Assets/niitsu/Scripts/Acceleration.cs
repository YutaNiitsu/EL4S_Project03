using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : ItemScript
{
    [Header("������Ԃ̑��x")] public float Speed = 5;
    [Header("������Ԃ��ێ����鎞��")] public float Time = 5;
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
        // �A�C�e��������
        Destroy(this.gameObject);
    }
}
