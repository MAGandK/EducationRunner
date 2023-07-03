using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCrush : MonoBehaviour
{
    public event Action ObstacleCrushs = delegate { };

    [SerializeField]
    private string _ignorePlayerColliizionLayer;

    private ObstacleElementas[] _elements;

    private void Start()
    {
        _elements = GetComponentsInChildren<ObstacleElementas>();

        for (int i = 0; i < _elements.Length; i++)
        {

            _elements[i].Setup(LayerMask.NameToLayer(_ignorePlayerColliizionLayer));
            _elements[i].Disable();

        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < _elements.Length; i++)
            {
                _elements[i].Enable();

            }
        }
    }

    public void Push()
    {
        for (int i = 0; i < _elements.Length; i++)
        {
            _elements[i].Enable();
        }

        ObstacleCrushs();
    }
}