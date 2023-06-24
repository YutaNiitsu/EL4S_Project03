using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMana : MonoBehaviour
{
    [SerializeField] [Tooltip("GOのマテリアル選択")] private Material Go;
    [SerializeField] [Tooltip("スタートマネージャー")] private StartMana StartMana;
    [SerializeField] [Tooltip("ゴールマネージャー")] private GoalMana goalMana;

    [SerializeField] private AnimationCurve animationCurve;
    [SerializeField] private float speed=0.1f;
    private float alpha;
    private float n;
    // Start is called before the first frame update
    void Start()
    {
        n = 0;
        StartCoroutine(Delay());
    }
    IEnumerator Delay()
    {
        float time = StartMana.Delay;
      
        yield return new WaitForSeconds(time);
        StartCoroutine(SetAlpha());
    }


    IEnumerator SetAlpha()
    {
        while (true)
        {
           
            n += speed;
            alpha=animationCurve.Evaluate(n);
            Go.SetFloat("_Alpha", alpha);
            yield return new WaitForSeconds(speed);

            if (n > 1) yield break;
        }

    }

}
