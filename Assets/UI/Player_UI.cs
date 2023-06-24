using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.x += 1.0f;
        transform.position = pos;
    }
}
