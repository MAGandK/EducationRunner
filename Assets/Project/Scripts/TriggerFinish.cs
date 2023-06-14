using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerFinish : MonoBehaviour
{
    [SerializeField]
    private LevelSettings _levelSettings;

    public static string LevelIndex = "Level";

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController playerController))
        {
            playerController.SetFinished();

            Debug.Log("Finish");

            OnFinished();
        }
    }

    private void OnFinished()
    {
        var levelIndex = PlayerPrefs.GetInt(StartUp.LevelKey);

        levelIndex++;

        PlayerPrefs.SetInt(StartUp.LevelKey, levelIndex);

        var sceneName = _levelSettings.GetSceneName(levelIndex);

        SceneManager.LoadScene(sceneName);
    }
}
