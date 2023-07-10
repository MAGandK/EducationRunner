using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleQTE : MonoBehaviour
{
    public static event Action ObstacleQTEs = delegate { };

    [SerializeField]
    private ObstacleKillCollider _killPlayerCollider;

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
            Time.timeScale = 0.5f;
            _isInteracted = true;
            ObstacleQTEs();
            player.Hit();
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
