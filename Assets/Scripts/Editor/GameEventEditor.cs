using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(GameEvent))]
    public class GameEventEditor:Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            GameEvent _gameEvent = (GameEvent)target;
            if (GUILayout.Button("Raise"))
            {
                _gameEvent.Raise();
            }
        }
    }
