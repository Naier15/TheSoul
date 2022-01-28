using UnityEngine;

namespace PlayerMove
{
    [RequireComponent(typeof(Transform))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private Transform _transform;
        
        private void Start()
        {
            _transform = GetComponent<Transform>();
        }

        public void Move()
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            transform.Translate(movement * _speed * Time.fixedDeltaTime);
        }
    }
}