using UnityEngine;

namespace PlayerMove
{
    public class InputController : MonoBehaviour
    {
        [SerializeField] private Mover _player;
        
        private InputHandler _inputHandler;

        private void Start()
        {
            _inputHandler = new InputHandler();
            _inputHandler.SetCommandA(new MoveLeft());
            _inputHandler.SetCommandD(new MoveRight());
            _inputHandler.SetCommandS(new MoveDown());
            _inputHandler.SetCommandW(new MoveUp());
        }

        private void FixedUpdate()
        {
            Command command = _inputHandler.handleInput();
            if (command != null)
            {
                command.Move(_player);
            }
        }
    }
}