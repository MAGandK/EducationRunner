using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{
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
        var index = PlayerPrefs.GetInt(LevelIndex);

        PlayerPrefs.SetInt(LevelIndex, ++index); //++index, который увеличит переменную
                                                 //index на 1 и вернет ее новое значение
    }
}
