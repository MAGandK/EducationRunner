using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public Rigidbody _rig;

    public FixedJoystick _fixedJoystick;

    [SerializeField]
    public float _speed = 1f;

    private Vector3 _direction;

    public GameObject _triggerStart;

    public GameObject _triggerFinish;


    // Start is called before the first frame update
    void Start()
    {
        if (_triggerStart != null && _triggerStart.GetComponent<Collider>() != null)
        {
            if (_triggerStart.GetComponent<Collider>().bounds.Contains(transform.position))
            {
                Debug.Log("GO!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        _direction = new Vector3(_fixedJoystick.Horizontal, 0, _fixedJoystick.Vertical);

        Vector3 newPosition = transform.position + _direction * _speed * Time.deltaTime;

        _rig.MovePosition(newPosition);

        if (_triggerFinish != null && _triggerStart.GetComponent<Collider>() != null)
        {
            if (_triggerFinish.GetComponent<Collider>().bounds.Contains(transform.position))
            {
                Debug.Log("Finish!");
            }
        }
    }

}
