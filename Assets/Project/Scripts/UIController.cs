using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainWindow;

    [SerializeField]
    private GameObject _finishWindow;

    [SerializeField]
    private GameObject _failWindow;

    // Start is called before the first frame update
    void Start()
    {
        ToggleMainWindow(false);

        ToggleFinishWindow(false);

        ToogleFailWindow(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleMainWindow(bool isActive)
    {
        _mainWindow.SetActive(isActive);
    }

    public void ToggleFinishWindow(bool isActive)
    {
        _finishWindow.SetActive(isActive);
    }

    public void ToogleFailWindow(bool isActive)
    {
        _failWindow.SetActive(isActive);
    }
}
