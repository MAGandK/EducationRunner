using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallQTE : MonoBehaviour
{
    public static event Action WallQTEs = delegate { };

    [SerializeField]
    private WallKillPlayer _killPlayerCollider; 

    private bool _isInteracted;

    private void OnEnable()
    {
        Joystick.Click += Joystick_Click;
    }

    private void OnDisable()
    {
        Joystick.Click -= Joystick_Click;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController player))
        {
            Time.timeScale = 0.3f;
            _isInteracted = true;
            WallQTEs();
        }
    }

    private void Joystick_Click()
    {
        if (_isInteracted)
        {
            Time.timeScale = 1;
            _killPlayerCollider.DisableKillAbility();
        }
    }
}
