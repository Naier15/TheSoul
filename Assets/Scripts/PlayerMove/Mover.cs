using UnityEngine;

namespace PlayerMove
{
    [RequireComponent(typeof(Rigidbody))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _rigidbody.AddForce(movement * _speed);
        }
    }
}