using System;
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
            _inputHandler.SetCommandA(new Move());
            _inputHandler.SetCommandD(new Move());
            _inputHandler.SetCommandS(new Move());
            _inputHandler.SetCommandW(new Move());
        }

        private void Update()
        {
            MoveCommand command = _inputHandler.handleInput();
            if (command != null)
            {
                command.Execute(_player);
            }
        }
    }
}