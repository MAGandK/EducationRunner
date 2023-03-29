using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick _fixedJoystick;

    [SerializeField]
    private float _speed = 1f;

    private Vector3 _direction;

    private float _moveX; // ограничение по ширине от -0.4 до 0.4

    private float _moveZ;

    private bool _finish = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    public void MovePlayer()
    {
        if (_finish)
        {
            return;
        }

        _direction = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);

        _moveX = Mathf.Clamp(transform.position.x + _direction.x * _speed * Time.deltaTime, -0.4f, 0.4f);

        _moveZ = (transform.position.z + _direction.z * _speed * Time.deltaTime);

        Vector3 newPosition = new Vector3(_moveX, transform.position.y, _moveZ);

        transform.position = newPosition;
    }

    public void SetFinished()
    {
        _finish = true;
    }
} 
