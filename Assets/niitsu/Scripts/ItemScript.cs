using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    protected Player PlayerScriptRef;
    // Start is called before the first frame update
    void Start()
    {
        PlayerScriptRef = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
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
