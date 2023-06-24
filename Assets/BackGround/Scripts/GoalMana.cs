using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMana : MonoBehaviour
{
    [Tooltip("Å‘åƒQ[ƒ€ŽžŠÔ")] public float MaXTime = 60.0f;
    [SerializeField] private StartMana StartMana;
    [SerializeField] private Manager manager;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        if(manager.GetPlayerMovingDistanceRatio()>1.0f)
        {
            StartMana.StopBackGround();
        }
    }
    //IEnumerator CheckTime()
    //{
    //    nowatime += Time.deltaTime;
    //    yield return new WaitForSeconds(MaXTime+StartMana.Delay);
    //    StartMana.StopBackGround();
    //}

   
}
