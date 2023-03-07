using UnityEngine;
using UnityEngine.Events;

public class DamageHealth: MonoBehaviour
    {
         public UnityEvent doDamage;

        public void TakeDamage()
        {
            doDamage.Invoke();
        }

     
          
        
    }
