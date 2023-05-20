using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WindowBace : MonoBehaviour
{
    public bool IsActive
    {
        get
        {
            return gameObject.activeSelf;
        }
    }

    public abstract int Index
    {
        get;
    } 

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }


}
