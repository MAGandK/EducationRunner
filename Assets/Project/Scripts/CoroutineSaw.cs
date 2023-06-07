using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSaw : MonoBehaviour
{
    [SerializeField]
    private Transform _objSaw;
    [SerializeField]
    private float _time;
    [SerializeField]
    private Transform _targetPositionSaw;
    [SerializeField]
    private float _rotetionSpeed;

    private Vector3 _startPosotionSaw;

    private void Start()
    {
        _startPosotionSaw = _objSaw.transform.position;

        StartCoroutine(MoveSowCor(_objSaw, _targetPositionSaw.position, _time));

    }

    private IEnumerator MoveSowCor(Transform obj, Vector3 targetPosition, float executionTime)
    {
        Vector3 startPosition = obj.transform.position;

        float angle = 0;

        while (true)
        {
            float time = 0;

            float progress = 0;

            while (time <= executionTime)
            {
                time += Time.deltaTime;

                progress = time / executionTime;

                angle -= _rotetionSpeed; // 

                obj.rotation = Quaternion.AngleAxis(angle, obj.forward); //указывает вдоль оси Z объекта в его собственной системе координат.

                obj.position = Vector3.Lerp(startPosition, targetPosition, progress);

                yield return null;
            }

            time = 0;

            while (time <= executionTime)
            {
                time += Time.deltaTime;

                progress = time / executionTime;

                angle += _rotetionSpeed; // 

                obj.rotation = Quaternion.AngleAxis(angle, obj.forward); //указывает вдоль оси Z объекта в его собственной системе координат.

                obj.position = Vector3.Lerp(targetPosition, startPosition, progress);

                yield return null;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(_targetPositionSaw.position, radius: 1);
    }
}
