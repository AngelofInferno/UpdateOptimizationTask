using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class TankMoving : MonoBehaviour, IUpdatable
    {
        private Transform playerTransform;

        private void Start()
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }
        

        public void Tick()
        {
            if (playerTransform != null)
            {
                transform.LookAt(playerTransform.position);
                transform.Translate(0, 0, 0.05f);
            }
        }
    }
}