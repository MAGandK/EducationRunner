using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailWindow : WindowBace
{
    [SerializeField]
    private Button _restartButton;

    [SerializeField]
    private SceneManagement _sceneManagement;

    public override int Index
    {
        get
        {
            return 1;
        }
    }

    private void Start()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
    }

    private void OnRestartButtonClick()
    {
        _sceneManagement.ReastartLevel();

    }
}
