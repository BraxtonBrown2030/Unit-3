using UnityEngine;
using UnityEngine.Events;


namespace Sctipts
{
    [CreateAssetMenu]
    public class classTesting : ScriptableObject
    {
        public float value;
        public UnityEvent MinValuEvent, MaxValueEvent;
        

        public void CheckminValue()
        {
            
            if(!(value < minValue)) return;

            MinValuEvent.Invoke();
            minValue = maxvalue;

        }

        /*
        
        powerup realate scripts
        
        bool
        float
        int 
        inmage 
        sound
        trigger evnet behoavor 
        
         
        */
        

    }
}