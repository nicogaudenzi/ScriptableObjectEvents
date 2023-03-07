using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class GameEventListener:MonoBehaviour
{
    public GameEvent mievento;
    public UnityEvent response;

    private void OnEnable()
    {
        mievento.RegisterListener(this);
    }

    private void OnDisable()
    { mievento.UnRegisterListener(this); }

    public void OnEventRaised()
    {
        response.Invoke();
    }
}
