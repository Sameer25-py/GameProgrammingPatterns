using DefaultNamespace;
using UnityEngine;

namespace ObserverPattern
{
    public class SubjectPlayer : Subject
    {
        #region GeneralVars

        private bool _isCollidedOnce;

        #endregion

        #region ColliderCallbacks

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag($"FinishLine") && !_isCollidedOnce)
            {
                _isCollidedOnce = true;
                NotifyAllObservers(GlobalConstants.LevelState.End);
            }
        }

        #endregion
    }
}