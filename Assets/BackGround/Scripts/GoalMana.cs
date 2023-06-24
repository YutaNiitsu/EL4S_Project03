using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMana : MonoBehaviour
{
    [SerializeField][Tooltip("ç≈ëÂÉQÅ[ÉÄéûä‘")] private float MaXTime = 60.0f;
    [SerializeField] private StartMana StartMana;
    private float nowatime;
    // Start is called before the first frame update
    void Start()
    {
        nowatime = 0.0f;
        StartCoroutine(CheckTime());
    }

    IEnumerator CheckTime()
    {
        nowatime += Time.deltaTime;
        yield return new WaitForSeconds(MaXTime+StartMana.Delay);
        StartMana.StopBackGround();
    }

    public float TimeRate()
    {
        return nowatime / MaXTime+StartMana.Delay;
    }
   
}
