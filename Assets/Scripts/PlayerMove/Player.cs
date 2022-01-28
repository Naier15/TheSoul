using System;
using UnityEngine;

namespace PlayerMove
{
    public enum PlayerState
    {
        OnThePortal,
        OnTheFloor
    };

    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerState _state;
        
        public PlayerState State => _state;

        private void ChangeState(PlayerState state)
        {
            _state = state;
        }

        private void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.TryGetComponent(out Portal portal))
            {
                ChangeState(PlayerState.OnThePortal);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Portal portal))
            {
                ChangeState(PlayerState.OnTheFloor);
            }
        }
    }
}