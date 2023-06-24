using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class CharaUI : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float _startPos;
    //[SerializeField] private float _goalPos;
    [SerializeField] private GameObject _road;
    [SerializeField] private float _goalLength;
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enemy1;
    [SerializeField] private GameObject _enemy2;
    [SerializeField] private GameObject _playerIcon;
    [SerializeField] private GameObject _enemy1Icon;
    [SerializeField] private GameObject _enemy2Icon;

    private float _oneMoveLength;

    void Start()
    {
        _oneMoveLength = _road.GetComponent<RectTransform>().sizeDelta.x / _goalLength;
    }

    // Update is called once per frame
    void Update()
    {
        //キャラクター内のポジションをもらう
        float playerPos = _player.transform.position.x/*TODO:内部パラメータをもらう*/ * _oneMoveLength + _startPos;
        float enemy1Pos = _enemy1.transform.position.x/*TODO:内部パラメータをもらう*/ * _oneMoveLength + _startPos;
        float enemy2Pos = _enemy2.transform.position.x/*TODO:内部パラメータをもらう*/ * _oneMoveLength + _startPos;

        RectTransform playerIconPos = _playerIcon.GetComponent<RectTransform>();
        RectTransform enemy1IconPos = _enemy1Icon.GetComponent<RectTransform>();
        RectTransform enemy2IconPos = _enemy2Icon.GetComponent<RectTransform>();
        playerIconPos.anchoredPosition = new Vector2(playerPos, playerIconPos.anchoredPosition.y);
        enemy1IconPos.anchoredPosition = new Vector2(playerPos, playerIconPos.anchoredPosition.y);
        enemy2IconPos.anchoredPosition = new Vector2(playerPos, playerIconPos.anchoredPosition.y);
    }
}
