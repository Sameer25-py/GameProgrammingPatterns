using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

namespace ObserverPattern
{
    public abstract class Subject : MonoBehaviour
    {
        #region GeneralVars

        [SerializeField] private List<Observer> observersList;

        #endregion

        #region PublicFunctions

        public bool AddObserver(Observer newObserver)
        {
            if (observersList.Contains(newObserver)) return false;
            observersList.Add(newObserver);
            return true;
        }

        public bool RemoveObserver(Observer observer)
        {
            if (!observersList.Contains(observer)) return false;
            observersList.Remove(observer);
            return true;
        }

        public void NotifyAllObservers(GlobalConstants.LevelState lvlState)
        {
            observersList.ForEach(observer => observer.OnNotify(lvlState));
        }

        #endregion

        #region UnityLifeCycle

        private void Start()
        {
            observersList = FindObjectsOfType<Observer>().ToList();
        }

        #endregion
    }
}