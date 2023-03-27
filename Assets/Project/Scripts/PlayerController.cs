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

    private float _Horizontal; // ограничение по ширине от -0.5 до 0.5

    private float _MoveLong; // ограничение по длине -8, 2

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
        _direction = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);

        _MoveLong = Mathf.Clamp(transform.position.x + _direction.x * _speed * Time.deltaTime, -8f, 2f); 

        _Horizontal = Mathf.Clamp(transform.position.z + _direction.z * _speed * Time.deltaTime, -0.5f, 0.5f); 

        Vector3 newPosition = new Vector3(_MoveLong, transform.position.y, _Horizontal);

        transform.position = newPosition;
    }
}