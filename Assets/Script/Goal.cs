using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] public float _goalPosition = 1000.0f;
    [SerializeField] public Player[] _player;

    public bool _isGoal;
    private Transform _transform;
    public int _nowRank;

    [SerializeField] private Color fadeColor = Color.black;
    [SerializeField] private float fadeSpeedMultiplier = 10.0f;
    void Start()
    {
        _transform = GetComponent<Transform>();

        if (_player == null)
            Debug.LogError("Playerが見つかりません。アタッチしてください");

        _nowRank = 1;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < _player.Length; i++)
        {
            if (_player[i] != null)
            {
                if (_player[i].GetMoveDistance() >= _goalPosition)
                {
                    _isGoal = true;
                    Debug.Log("五ーーーる");
                    _player[i].SetSpeed(0.0f);
                    if (i == 0)
                    {
                        _player[i].SetPlayerRank(_nowRank);
                    }
                    else
                    {
                        _player[i].SetEnemyRank(_nowRank, i);
                    }
                    _player[i] = null;
                    _nowRank++;
                }
            }
        }

        if (!_isGoal)
        {
            float distance = _goalPosition - _player[0].GetMoveDistance();
            Vector3 pos = _transform.position;
            _transform.position = new Vector3(_player[0].transform.position.x + distance, pos.y, 0.0f);

        }


        if (_nowRank >= 4)
        {
            Initiate.Fade("Result", fadeColor, fadeSpeedMultiplier);
        }
    }
}