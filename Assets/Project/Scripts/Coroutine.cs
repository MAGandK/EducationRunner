using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    [SerializeField]
    private Transform _object;

    [SerializeField]
    private float _time;

    [SerializeField]
    private Transform _targetPos; //цель позиции

    private Vector3 _startPosition;

    [SerializeField]
    private float _rotetionSpeed;

    private void Start()
    {
        _startPosition = _object.transform.position;

        StartCoroutine(MoveCor(_object, _targetPos.position, _time));

    }


    private IEnumerator MoveCor(Transform obj, Vector3 targetPosition, float executionTime) //время выполнения
    {
        Vector3 startPosition = obj.transform.position;

        float angle = 0;

        while (true)
        {
            float time = 0;

            float progress = 0;

            while (time <= executionTime)
            {
                time += Time.deltaTime; //чтобы понять сколько корутина работает

                progress = time / executionTime;

                angle += _rotetionSpeed;
                obj.rotation = Quaternion.AngleAxis(angle, obj.up);

                obj.position = Vector3.Lerp(startPosition, targetPosition, progress);

                yield return null;
            }

            time = 0;

            while (time <= executionTime)
            {
                time += Time.deltaTime; //чтобы понять сколько корутина работает

                progress = time / executionTime;

                angle += _rotetionSpeed;
                obj.rotation = Quaternion.AngleAxis(angle, obj.up);

                obj.position = Vector3.Lerp(targetPosition, startPosition, progress);

                yield return null;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(_targetPos.position, radius: 1);
    }
}
