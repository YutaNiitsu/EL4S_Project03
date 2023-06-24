using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class CharaUI : MonoBehaviour
{
    // Start is called before the first frame update

    private float _startPos;
    //[SerializeField] private float _goalPos;
    [SerializeField] private GameObject _road;
    [SerializeField] private float _goalLength;
    [SerializeField] private Player _player;
    [SerializeField] private EnemyPlayer _enemy1;
    [SerializeField] private EnemyPlayer _enemy2;
    [SerializeField] private GameObject _playerIcon;
    [SerializeField] private GameObject _enemy1Icon;
    [SerializeField] private GameObject _enemy2Icon;


    private float _oneMoveLength;

    void Start()
    {
        _oneMoveLength = _road.GetComponent<RectTransform>().sizeDelta.x / _goalLength;
        _startPos = _road.GetComponent<RectTransform>().sizeDelta.x * 0.5f * -1.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //�L�����N�^�[���̃|�W�V���������炤
        float playerPos = _player.GetMoveDistance()/*TODO:�����p�����[�^�����炤*/ * _oneMoveLength + _startPos;
        float enemy1Pos = _enemy1.GetMoveDistance()/*TODO:�����p�����[�^�����炤*/ * _oneMoveLength + _startPos;
        float enemy2Pos = _enemy2.GetMoveDistance()/*TODO:�����p�����[�^�����炤*/ * _oneMoveLength + _startPos;

        RectTransform playerIconPos = _playerIcon.GetComponent<RectTransform>();
        RectTransform enemy1IconPos = _enemy1Icon.GetComponent<RectTransform>();
        RectTransform enemy2IconPos = _enemy2Icon.GetComponent<RectTransform>();
        playerIconPos.anchoredPosition = new Vector2(playerPos, playerIconPos.anchoredPosition.y);
        enemy1IconPos.anchoredPosition = new Vector2(enemy1Pos, enemy1IconPos.anchoredPosition.y);
        enemy2IconPos.anchoredPosition = new Vector2(enemy2Pos, enemy2IconPos.anchoredPosition.y);
    }
}
