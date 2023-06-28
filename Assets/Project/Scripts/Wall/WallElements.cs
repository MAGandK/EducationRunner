using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallElements : MonoBehaviour
{
    private float _force = 20;

    private Rigidbody _rb;

    private int _ignorePlayerLayer;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Setup(int layer)
    {
        _ignorePlayerLayer = layer;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerController  playerController))
        {
            var direction = (collision.contacts[0].point - playerController.transform.position).normalized;
            _rb.AddForce(direction * _force, ForceMode.Impulse);
            gameObject.layer = _ignorePlayerLayer;
        }
    }

    public void Disable()
    {
        _rb.useGravity = false;
        _rb.isKinematic = true;
        _rb.velocity = Vector3.zero;
    }

    public void Enable()
    {
        _rb.useGravity = true;
        _rb.isKinematic = false;
        _rb.velocity = Vector3.zero;
    }
}
