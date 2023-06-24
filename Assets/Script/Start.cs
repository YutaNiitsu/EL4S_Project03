using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFlag : MonoBehaviour
{
    [SerializeField] public float _startPosition = 0.0f;
    [SerializeField] public Player _player;

    private Transform _transform;

    void Start()
    {
        _transform = GetComponent<Transform>();

        if (_player == null)
            Debug.LogError("Playerが見つかりません。アタッチしてください");

    }

    // Update is called once per frame
    void Update()
    {
        float distance = _startPosition - _player.GetMoveDistance();
        _transform.position = _player.transform.position + new Vector3(distance, 0.0f, 0.0f);
    }
}
