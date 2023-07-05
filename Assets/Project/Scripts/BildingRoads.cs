using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BildingRoads : MonoBehaviour
{
    public float _offset;

    public Transform[] _Transforms;

    public Transform _targetPos;

    private void OnValidate()
    {
        Vector3 pos = _targetPos.position;

        for (int i = 0; i < _Transforms.Length; i++)
        {
            pos = new Vector3(i * _offset, 0, 0);

            _Transforms[i].position = pos;
        }
    }

}
