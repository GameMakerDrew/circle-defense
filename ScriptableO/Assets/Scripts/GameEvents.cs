using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action onRightClick;
    public void RightClick()
    {
        onRightClick?.Invoke();
    }

    public event Action onPressedQ;
    public void PressedQ()
    {
        onPressedQ?.Invoke();
    }

    public event Action onCursorReset;
    public void CursorReset()
    {
        onCursorReset?.Invoke();
    }

    public event Action onActorAdded;
    public void ActorAdded()
    {
        onActorAdded?.Invoke();
    }


}
