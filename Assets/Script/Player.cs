using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float _defaultSpeed = 1.0f;
    [SerializeField] public float _moveSpeed;
    [SerializeField] public bool _isStart;
    //[SerializeField] Item _nowItem;
    public float _moveDistance;
    protected bool _isGodMode;

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
    public void SetSpeed(float ratio)
	{
        _moveSpeed *= ratio;
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
