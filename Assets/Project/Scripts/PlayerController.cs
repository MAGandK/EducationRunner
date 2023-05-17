using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string RunAnimationKey = "IsRun";
    private readonly string DiedAnimationKey = "Died";
    private readonly string DancedAnimationKey = "Danced";

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
    private UIController _uIController;
    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private Joystick _joystick;
    [SerializeField, Range(0f,1f)]
    private float _swipeSensivity;
    
    private float _moveX; // ограничение по ширине от -0.4 до 0.4
    private float _moveZ;
    private bool _isFinished = false;
    private bool _isStarted = false;
    private bool _isDied = false;
    
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
        if (_isFinished || !_isStarted || _isDied)
        {
            return;
        }
        
        var position = transform.position;
        var expectedMoveX = position.x + (_joystick.EventDataDelta.x * _swipeSensivity) * (_speed * Time.deltaTime);
        
        _moveX = Mathf.Clamp(expectedMoveX, -3.2f, 3.2f);
        _moveZ = position.z + _forwardSpeed * Time.deltaTime;

        Vector3 newPosition = new Vector3(_moveX, position.y, _moveZ);

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

        _animator.SetTrigger(DancedAnimationKey);
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
        _isDied = true;

        _uIController.ToogleFailWindow(true);

        _animator.SetTrigger(DiedAnimationKey);
    }

    
}