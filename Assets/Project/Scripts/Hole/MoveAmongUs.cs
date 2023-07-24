using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAmongUs : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        var direction = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(direction, Vector3.up);
    }

}
