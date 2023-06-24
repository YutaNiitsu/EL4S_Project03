using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [Header("アイテムの速度")] public float Speed = 0.2f;
    protected Player PlayerScriptRef;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScriptRef = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }
    private void FixedUpdate()
    {
        transform.position += new Vector3(-Speed, 0.0f, 0.0f); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void UseItem()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlayerHit");
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            UseItem();
        }
    }
}
