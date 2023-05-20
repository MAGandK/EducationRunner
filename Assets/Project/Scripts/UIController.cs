using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    private WindowBace[] _windows;

    private void Awake()
    {
        _windows = GetComponentsInChildren<WindowBace>(true);
    }

    public void ShowWindow(int index)
    {
        for (int i = 0; i < _windows.Length; i++)
        {
            if (_windows[i].Index == index)
            {
                _windows[i].Show();
            }
            else
            {
                _windows[i].Hide();
            }
        }
    }
}

