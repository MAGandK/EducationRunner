using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private readonly string RunAnimationKey = "IsRun";
    private readonly string DiedAnimationKey = "Died";

    [SerializeField]
    private FixedJoystick _fixedJoystick;
    [SerializeField]
    private float _speed = 1f;
    [SerializeField]
    private float _forwardSpeed = 0f; // скорость вперед
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private Vector3 _jumpForce;
    [SerializeField]
    private Text _coinText;
    [SerializeField]
    private UIController _uIController;
    [SerializeField]
    private Animator _animator;

    private float _moveX; // ограничение по ширине от -0.4 до 0.4
    private float _moveZ;
    private bool _isFinished = false;
    private bool _isStarted = false;
    private bool _isDaed = false;

    private Vector3 _direction;

    private void Start()
    {
        _isStarted = false;
    }

    private void Update()
    {    
        if (Input.GetMouseButtonDown(0) && !_isStarted)// Если было сделано касание на экране, запускаем игру
        {
            StartGame();
        }

        MovePlayer();
    }

    public void MovePlayer()
    {

        if (_isFinished || !_isStarted || _isDaed)
        {
            return;
        }

        _direction = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);
        
        _moveX = Mathf.Clamp(transform.position.x + _direction.x * _speed * Time.deltaTime, -0.4f, 0.4f);

        _moveZ = (transform.position.z + _forwardSpeed * Time.deltaTime);

        Vector3 newPosition = new Vector3(_moveX, transform.position.y, _moveZ);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        _rigidbody.MovePosition(newPosition);
    }

    public void SetFinished()
    {
        _isFinished = true;

        _uIController.ToggleFinishWindow(true);
    }

    private void StartGame()
    {
        _isStarted = true;

        _uIController.ToggleMainWindow(true);

        _animator.SetBool(RunAnimationKey, true);
    }

    public void Jump()
    {
        _rigidbody.AddForce(_jumpForce, ForceMode.Impulse);
    }

    public void Die()
    {
        _isDaed = true;

        _uIController.ToogleFailWindow(true);

        _animator.SetTrigger(DiedAnimationKey);
    }

    
}