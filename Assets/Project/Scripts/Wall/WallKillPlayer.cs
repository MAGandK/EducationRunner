using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallKillPlayer : MonoBehaviour
{
    [SerializeField]
    private Wall _wall;

    private Collider _collider;

    private bool _isKilleble;

    private void Awake()
    {
        _isKilleble = true;
        _collider = GetComponent<Collider>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerController))
        {
            if (_isKilleble)
            {
                Time.timeScale = 1;
                playerController.Die();
            }
            else
            {
                _wall.Push();
            }
        }
    }

    internal void DisableKillAbility()
    {
        _isKilleble = false;
    }
}
