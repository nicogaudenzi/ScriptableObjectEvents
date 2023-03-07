 using UnityEditor;
 using UnityEngine;

 [CustomEditor(typeof(DamageHealth))]
   public class DoDamageEditor:Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            DamageHealth _myScript = (DamageHealth)target;
            if (GUILayout.Button("Haz Daño"))
            {
                _myScript.TakeDamage();
            }
        }
    }
