using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineHammer : MonoBehaviour
{
    [SerializeField] private Transform _object;
    [SerializeField] private float _time;
    [SerializeField] private float _rotationUpAngle;
    [SerializeField] private float _rotationDownAngle;
    [SerializeField] private float _rotationSpeed;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = _object.transform.position;
        StartCoroutine(MoveHammer());
    }

    private IEnumerator MoveHammer()
    {
        while (true)
        {
            // Поднятие молотка
            float elapsedTime = 0f;
            Quaternion startRotation = _object.rotation;
            Quaternion targetRotation = Quaternion.Euler(_rotationUpAngle, _object.rotation.eulerAngles.y, _object.rotation.eulerAngles.z);

            while (elapsedTime < _time)
            {
                float t = elapsedTime / _time;
                _object.rotation = Quaternion.Lerp(startRotation, targetRotation, t);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            _object.rotation = targetRotation;

            // Опускание молотка
            elapsedTime = 0f;
            startRotation = _object.rotation;
            targetRotation = Quaternion.Euler(_rotationDownAngle, _object.rotation.eulerAngles.y, _object.rotation.eulerAngles.z);

            while (elapsedTime < _time)
            {
                float t = elapsedTime / _time;
                _object.rotation = Quaternion.Lerp(startRotation, targetRotation, t);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            _object.rotation = targetRotation;

        }
    }
}

