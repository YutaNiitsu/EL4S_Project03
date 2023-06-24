using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _defaultSpeed = 1.0f;
    [SerializeField] float _moveSpeed;
    [SerializeField] bool _isStart;
    //[SerializeField] Item _nowItem;
    private float _moveDistance;
    private bool _isGodMode;

    void Start()
    {
        _moveSpeed = _defaultSpeed;
        _isStart = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // �X�^�[�g�̃J�E���g���I�����ĊJ�n������
        if(_isStart)
		{
            _moveDistance += _moveSpeed;

		}
    }

    public float GetMoveDistance()
	{
        return _moveDistance;
	}
    public void SetSpeed(float speed)
	{
        _moveSpeed = speed;
	}
    public void SetDefaultSpeed()
    {
        _moveSpeed = _defaultSpeed;
    }

    public void SetGodFlag(bool value)
	{
        _isGodMode = value;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.CompareTag("Item"))
		{
            // �A�C�e�����Ƃ������̋����̏���

		}
	}
}
