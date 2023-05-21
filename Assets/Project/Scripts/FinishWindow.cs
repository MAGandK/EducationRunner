using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishWindow : WindowBace
{
    [SerializeField]
    private Button _nextLevelButton;

    [SerializeField]
    private SceneManagement _sceneManagement;

    public override int Index
    {
        get
        {
            return 2;
        }
    }

    private void Start()
    {
        _nextLevelButton.onClick.AddListener(OnNextButtonClick);
    }

    private void OnNextButtonClick()
    {
        _sceneManagement.LoadNextLevel();
    }
}
