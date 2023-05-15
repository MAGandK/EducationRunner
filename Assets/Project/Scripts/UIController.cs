using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainWindow;
    [SerializeField]
    private GameObject _finishWindow;
    [SerializeField]
    private GameObject _failWindow;
    [SerializeField]
    private Button _restartButton;
    [SerializeField]
    private Button _nextLevelButton;
    [SerializeField]
    private SceneManagement _sceneManagement;

    private void Start()
    {
        ToggleMainWindow(false);

        ToggleFinishWindow(false);

        ToogleFailWindow(false);

        _restartButton.onClick.AddListener(OnRestartButtonClick);

        _nextLevelButton.onClick.AddListener(OnNextButtonClick);

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

    private void OnRestartButtonClick()
    {
        _sceneManagement.ReastartLevel();
    }

    private void OnNextButtonClick()
    {
        _sceneManagement.LoadNextLevel();
    }
}

