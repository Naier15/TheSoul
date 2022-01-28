using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace PlayerMove
{
    [RequireComponent(typeof(Transform))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _playerModel;
        
        private Transform _transform;
        
        private void Start()
        {
            _transform = GetComponent<Transform>();
        }

        public void Move()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _transform.Translate(movement * _speed * Time.fixedDeltaTime);
        }
        
        public void Rotate(float angleY)
        {
            float currentRotationY = _playerModel.rotation.eulerAngles.y;
            float angleDifference = angleY - currentRotationY;
            
            _playerModel.Rotate(0, 0, angleDifference); 
        }
    }
}