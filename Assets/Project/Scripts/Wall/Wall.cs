using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    private string _ignorePlayerColliizionLayer;

    private WallElements[] _elements;

    private void Start()
    {
        _elements = GetComponentsInChildren<WallElements>();

        for (int i = 0; i < _elements.Length; i++)
        {

            _elements[i].Setup(LayerMask.NameToLayer(_ignorePlayerColliizionLayer));
            _elements[i].Disable();
 
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
    }
}
