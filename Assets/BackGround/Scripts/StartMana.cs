using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMana : MonoBehaviour
{
    public float Delay = 3.0f;
    [SerializeField][Tooltip("�w�i�̃}�e���A���I��")] private Material BackGround;
    [SerializeField] [Tooltip("���̃}�e���A���I��")] private Material Rail;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayTime());

    }

    IEnumerator DelayTime()
    {
        StopBackGround();
        yield return new WaitForSeconds(Delay);

        StartBackGround();
        //�����ŃX�^�[�g
    }

    public void StopBackGround()
    {
        BackGround.SetFloat("_isStop", 1.0f);
        Rail.SetFloat("_isStop", 1.0f);
    }

public void StartBackGround()
    {
        BackGround.SetFloat("_isStop", 0.0f);
        Rail.SetFloat("_isStop", 0.0f);
    }
}
