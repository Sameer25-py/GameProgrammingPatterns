using System;
using System.Net;
using Unity.VisualScripting;

namespace DefaultNamespace
{
    public class GlobalConstants
    {
        [Serializable]
        public enum LevelState
        {
            Start = 0,
            End   = 1
        }
    }
}