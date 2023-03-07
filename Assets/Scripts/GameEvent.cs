using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
  private List<GameEventListener> _listeners = new List<GameEventListener>();

  public void Raise()
  {
    for (int i = _listeners.Count-1;i >= 0; i--)
    {
      _listeners[i].OnEventRaised();
    }
  }

  public void RegisterListener(GameEventListener _listener)
  {
    if(!_listeners.Contains(_listener))
      _listeners.Add(_listener);
  }
  public void UnRegisterListener(GameEventListener _listener)
  {
    if(_listeners.Contains(_listener))
      _listeners.Remove(_listener);
  }  
}

