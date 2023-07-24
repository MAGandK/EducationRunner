using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotetionCube : MonoBehaviour
{
    //public Transform transform;
    //[SerializeField]
    //private GameObject gameObject;
    //public float rotationSpeed = 100f;

    //private void Update()
    //{
    //    MoveCube();
    //}

    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            Quaternion rotationY = Quaternion.AngleAxis(10, Vector3.up);
            transform.rotation *= rotationY;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Quaternion rotationY = Quaternion.AngleAxis(-10, Vector3.up);
            transform.rotation *= rotationY;
        }

    }

    //private void MoveCube()
    //{
    //    if (Input.GetKeyDown(KeyCode.D))
    //    {
    //        //gameObject.transform.Rotate(Vector3.up, 10f);
            

    //    }

    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        gameObject.transform.Rotate(Vector3.up, -10f);
    //        //gameObject.transform.eulerAngles += Vector3.up;
    //    }
    //}
}
