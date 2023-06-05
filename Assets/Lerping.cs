using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lerping : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    [SerializeField]
    private Transform _cube;

    [SerializeField]
    private Transform _cubeNewPosition;

    private Vector3 _cubePosition;

    


    public void Update()
    {
        _cube.position = Vector3.Lerp(_cubePosition, _cubeNewPosition.position, _slider.value);


    }

}
