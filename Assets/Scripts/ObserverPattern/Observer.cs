using DefaultNamespace;
using UnityEngine;

namespace ObserverPattern
{
    public abstract class Observer : MonoBehaviour
    {   
        public abstract void OnNotify(GlobalConstants.LevelState lvlState);
    }
}