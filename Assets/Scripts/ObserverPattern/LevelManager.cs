using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObserverPattern
{
    public class LevelManager : Observer
    {
        #region HelperFunctions

        private void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene()
                .name);
        }

        #endregion

        #region InterfaceMethods

        public override void OnNotify(GlobalConstants.LevelState lvlState)
        {
            if (lvlState == GlobalConstants.LevelState.End)
            {
                Debug.Log(@"Level Ended!!!!!\nRestarting in 1s");
                Invoke(nameof(RestartLevel), 1f);
            }
        }

        #endregion
    }
}