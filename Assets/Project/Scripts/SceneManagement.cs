using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ReastartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextLevel() // Load - загрузить 
    {
        var index = PlayerPrefs.GetInt(TriggerFinish.LevelIndex);

        SceneManager.LoadScene(index);
    }
}