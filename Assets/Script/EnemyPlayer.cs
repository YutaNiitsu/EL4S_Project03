using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayer : Player
{
    [SerializeField] Player _player;

    Transform _transform;

    [SerializeField] public float _minNum = 0.7f;
    [SerializeField] public float _maxNum = 1.3f;
    [SerializeField] public float _offset = 1.0f;

    void Start()
    {
        _moveSpeed = _defaultSpeed;

        _transform = GetComponent<Transform>();

        if(_player == null)
            Debug.LogError("Playerが見つかりません。アタッチしてください");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = _moveDistance - _player.GetMoveDistance();
        _transform.position = _player.transform.position + new Vector3(distance * _offset,0.0f,0.0f);

        if (_isStart)
        {
            _moveDistance += _moveSpeed * Random.Range(_minNum, _maxNum);
        }
        
    }
}
