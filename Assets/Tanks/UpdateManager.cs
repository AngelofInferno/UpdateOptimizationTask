using System;
using UnityEngine;

namespace DefaultNamespace
{
    public interface IUpdatable
    {
        void Tick();
    }
    
    public class UpdateManager : MonoBehaviour
    {
        private IUpdatable[] _updatables;
        private int i;   
        

        private void Update()
        {
            foreach (var upd in _updatables)
            {
                upd.Tick();
            }
        }

        public void Init(int count)
        {
            _updatables = new IUpdatable[count];
        }

        public void AddElement(IUpdatable updatable)
        {
            _updatables[i++] = updatable;
        }

        private void RemoveElement(int index)
        {
            _updatables[index] = null;
        }
    }
}