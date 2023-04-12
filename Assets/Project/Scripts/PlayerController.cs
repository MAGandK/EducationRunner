using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private FixedJoystick _fixedJoystick;

    [SerializeField]
    private float _speed = 1f;

    [SerializeField]
    private float _forwardSpeed = 0f;

    private Vector3 _direction;

    private float _moveX; // ограничение по ширине от -0.4 до 0.4

    private float _moveZ;

    private bool _isFinish = false;

    private bool _isStarted = false;

    private int _coinCount = 0;

    [SerializeField]
    private Rigidbody _rigidbody;

    [SerializeField]
    private Vector3 _jumpForce;

    [SerializeField]
    private Text _coinText;

    // Start is called before the first frame update
    void Start()
    {
        _isStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)// Если было сделано касание на экране, запускаем игру
       
        if (Input.GetMouseButtonDown(0))// Если было сделано касание на экране, запускаем игру
        {
            StartGame();
        }

        MovePlayer();
    }

    public void MovePlayer()
    {
        //&& ||
        if (_isFinish || !_isStarted)
        {
            return;
        }

        _direction = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);
        
        _moveX = Mathf.Clamp(transform.position.x + _direction.x * _speed * Time.deltaTime, -0.4f, 0.4f);

        //_moveZ = (transform.position.z + _direction.z * _speed * Time.deltaTime);
        _moveZ = (transform.position.z + _forwardSpeed * Time.deltaTime);

        Vector3 newPosition = new Vector3(_moveX, transform.position.y, _moveZ);

        transform.position = newPosition;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        _rigidbody.MovePosition(newPosition);
    }

    public void SetFinished()
    {
        _isFinish = true;
    }

    private void StartGame()
    {
        _isStarted = true;
    }

    public void CollectCoin()
    {
        _coinCount++;

        _coinText.text = $"{_coinCount}";
    }

    public void Jump()
    {
        _rigidbody.AddForce(_jumpForce, ForceMode.Impulse);
    }
}